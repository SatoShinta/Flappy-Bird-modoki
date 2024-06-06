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
        //"Logic"�^�O���t�����I�u�W�F�N�g��T���A���̃I�u�W�F�N�g�ɃA�^�b�`����Ă���LogicManager�R���|�[�l���g���擾����
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //player��y���̃|�W�V�������擾����
        float player_Berd = transform.position.y;

        //�����A�X�y�[�X�L�[��������A���Aplayer�������Ă��邩�̃t���O��true��������
        if(Input.GetKeyDown(KeyCode.Space)  && birdIsAlive == true)
        {
            //������RigitBody�R���|�[�l���g���Q�Ƃ��Avelocity�v���p�e�B���g�p���Avector2.up�ŏ�����̗́i�O�C�P�j�����������flapStrength���������l���t�^�����
            myRigitbody.velocity = Vector2.up * flapStrength;

        }
        
        //����player��y���̈ʒu����߂�ꂽ���W���ォ���ɍs����������
        if (player_Berd < minY || player_Berd > maxY)
        {
            //LogicManager�N���X��gameOver���\�b�h���Ăяo��
            logic.gameOver();
            //player�̐����t���O��false�ɂ���
            birdIsAlive = false;
        }
    }

    //���̃I�u�W�F�N�g�ɉ����R���C�_�[�����I�u�W�F�N�g���Ԃ������ꍇ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //LogicManager�N���X��gameOver���\�b�h���Ăяo��
        logic.gameOver();
        //player�̐����t���O��false�ɂ���
        birdIsAlive = false;
    }
}
