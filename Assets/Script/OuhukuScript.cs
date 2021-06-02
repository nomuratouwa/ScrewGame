using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuhukuScript : MonoBehaviour
{

    public float speed = 0.05f;         //スピ―ド
    public float Kyori = 100;           //距離
    public bool Yoko = true;            //
    public bool Tate = true;            //横化縦かどっちもトル―だと斜め

    private int Kyoricount;
    private int count = 0;

    void Start()
    {
        Kyoricount = (int)(Kyori / speed);      //スピードと距離から往復する時間の計算
    }

    void Update()
    {
        Vector2 vec2 = new Vector2(0, 0);        //リセット
        if (Yoko)
            vec2 = vec2 + new Vector2(speed, 0); //横に
        if (Tate)
            vec2 = vec2 + new Vector2(0, speed); //縦に
        transform.Translate(vec2);
        count++;

        //countが100になれば-1を掛けて逆方向に動かす
        if (count == Kyoricount)
        {
            count = 0;
            speed *= -1;
        }
    }
}
