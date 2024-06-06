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
        //���̃I�u�W�F�N�g��transform�R���|�[�l���g��position���ڂ́Avecter3.left(���ɂP)�~moveSpeed�~1�b������
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        //�����A���̃I�u�W�F�N�g��transform.position���f�b�h�]�[���ɐݒ肵�����W�𒴂�����
        if (transform.position.x < deadZone)
        {
            //debug���O������
            Debug.Log("Pipe Delete");
            //���̃I�u�W�F�N�g��j�󂷂�
            Destroy(gameObject);
        }
    }
}
