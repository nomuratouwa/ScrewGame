using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuhukuScript : MonoBehaviour
{

    public float speed = 0.05f;         //�X�s�\�h
    public float Kyori = 100;           //����
    public bool Yoko = true;            //
    public bool Tate = true;            //�����c���ǂ������g���\���Ǝ΂�

    private int Kyoricount;
    private int count = 0;

    void Start()
    {
        Kyoricount = (int)(Kyori / speed);      //�X�s�[�h�Ƌ������牝�����鎞�Ԃ̌v�Z
    }

    void Update()
    {
        Vector2 vec2 = new Vector2(0, 0);        //���Z�b�g
        if (Yoko)
            vec2 = vec2 + new Vector2(speed, 0); //����
        if (Tate)
            vec2 = vec2 + new Vector2(0, speed); //�c��
        transform.Translate(vec2);
        count++;

        //count��100�ɂȂ��-1���|���ċt�����ɓ�����
        if (count == Kyoricount)
        {
            count = 0;
            speed *= -1;
        }
    }
}
