using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleObject : MonoBehaviour
{
//LogicManagerを取得する
    public LogicManager logic;

    // Start is called before the first frame update
    void Start()
    {
    //logicの中にタグ"Logic"がついているオブジェクトのLogicManagerコンポーネントを取得する
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    //トリガーに当たったゲームオブジェクトのレイヤーが３だったら
        if (collision.gameObject.layer == 3)
        {
        //logicのaddScoreメソッドに１を返す
            logic.addScore(1);

        }
    }
}
