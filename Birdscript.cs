using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myRigitbody;
    public float flapStrength;
    public LogicManager logic;
    public bool birdIsAlive = true;
    public float minY = -18;
    public float maxY = 18;

    // Start is called before the first frame update
    void Start()
    {
        //"Logic"タグが付いたオブジェクトを探し、そのオブジェクトにアタッチされているLogicManagerコンポーネントを取得する
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //playerのy軸のポジションを取得する
        float player_Berd = transform.position.y;

        //もし、スペースキーが押され、かつ、playerが生きているかのフラグがtrueだったら
        if(Input.GetKeyDown(KeyCode.Space)  && birdIsAlive == true)
        {
            //自分のRigitBodyコンポーネントを参照し、velocityプロパティを使用し、vector2.upで上方向の力（０，１）を加えそれにflapStrengthをかけた値が付与される
            myRigitbody.velocity = Vector2.up * flapStrength;

        }
        
        //もしplayerのy軸の位置が定められた座標より上か下に行きすぎたら
        if (player_Berd < minY || player_Berd > maxY)
        {
            //LogicManagerクラスのgameOverメソッドを呼び出し
            logic.gameOver();
            //playerの生存フラグをfalseにする
            birdIsAlive = false;
        }
    }

    //このオブジェクトに何かコライダーを持つオブジェクトがぶつかった場合
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //LogicManagerクラスのgameOverメソッドを呼び出し
        logic.gameOver();
        //playerの生存フラグをfalseにする
        birdIsAlive = false;
    }
}
