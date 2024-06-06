using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //このオブジェクトのtransformコンポーネントのposition項目は、vecter3.left(左に１)×moveSpeed×1秒ずつ動く
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        //もし、このオブジェクトのtransform.positionがデッドゾーンに設定した座標を超えたら
        if (transform.position.x < deadZone)
        {
            //debugログをだし
            Debug.Log("Pipe Delete");
            //このオブジェクトを破壊する
            Destroy(gameObject);
        }
    }
}
