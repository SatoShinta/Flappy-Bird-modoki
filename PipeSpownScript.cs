using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpownScript : MonoBehaviour
{
    //ゲームオブジェクトを選択する
    public GameObject pipe;
    //スポーン時間を設定する
    public float spawnRate = 2;
    //タイマー(初期値ゼロ)
    private float timer = 0;
    //pipeの位置調整用の値
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        //ゲーム開始時一度だけspawnPipe関数を呼び出す
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //もし、timerがspawnRateよりも小さい値だったら
        if (timer <= spawnRate)
        {
            //タイマーに1秒追加する
            timer += Time.deltaTime;
        }
        //timerがspawnRateより大きくなったら
        else
        {
            //spawnPipe変数を呼び出し、timerを0にする
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        //出現させるパイプの一番低い位置を設定する（このオブジェクトのy座標－heightOffsetに設定した値）
        float lowestPoint = transform.position.y - heightOffset;
        //出現するpipeの一番高い位置を設定する（このオブジェクトのy座標－heightOffsetに設定した値）
        float highestPoint = transform.position.y + heightOffset;

        //生成する、pipeにセットしたオブジェクトを、x軸はこのオブジェクトと同じ位置で、y軸はlowestPointとhigestpointに設定した値のうちランダムに決定され、z軸は０で、回転はこのオブジェクトと同じでずっとまっすぐ
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
    }
}
