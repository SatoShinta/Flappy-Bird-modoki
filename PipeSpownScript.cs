using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpownScript : MonoBehaviour
{
    //�Q�[���I�u�W�F�N�g��I������
    public GameObject pipe;
    //�X�|�[�����Ԃ�ݒ肷��
    public float spawnRate = 2;
    //�^�C�}�[(�����l�[��)
    private float timer = 0;
    //pipe�̈ʒu�����p�̒l
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        //�Q�[���J�n����x����spawnPipe�֐����Ăяo��
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //�����Atimer��spawnRate�����������l��������
        if (timer <= spawnRate)
        {
            //�^�C�}�[��1�b�ǉ�����
            timer += Time.deltaTime;
        }
        //timer��spawnRate���傫���Ȃ�����
        else
        {
            //spawnPipe�ϐ����Ăяo���Atimer��0�ɂ���
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        //�o��������p�C�v�̈�ԒႢ�ʒu��ݒ肷��i���̃I�u�W�F�N�g��y���W�|heightOffset�ɐݒ肵���l�j
        float lowestPoint = transform.position.y - heightOffset;
        //�o������pipe�̈�ԍ����ʒu��ݒ肷��i���̃I�u�W�F�N�g��y���W�|heightOffset�ɐݒ肵���l�j
        float highestPoint = transform.position.y + heightOffset;

        //��������Apipe�ɃZ�b�g�����I�u�W�F�N�g���Ax���͂��̃I�u�W�F�N�g�Ɠ����ʒu�ŁAy����lowestPoint��higestpoint�ɐݒ肵���l�̂��������_���Ɍ��肳��Az���͂O�ŁA��]�͂��̃I�u�W�F�N�g�Ɠ����ł����Ƃ܂�����
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
    }
}
