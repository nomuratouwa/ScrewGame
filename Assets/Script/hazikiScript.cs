using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazikiScript : MonoBehaviour
{
    [SerializeField] private float Takasa = 100;    //↑に飛ぶ強さの最大値
    [SerializeField] private float Yoko = 100;      //横に飛ぶ強さの最大値
    private Rigidbody2D RB;

    void Start()
    {
        Takasa = Random.Range(0, Takasa);           //↑の強さをランダムに
        Yoko = Random.Range(-1 * Yoko, Yoko);       //左右の強さをランダムに
        RB = GetComponent<Rigidbody2D>();
        RB.AddForce(transform.up * Takasa);         //上方向の力を加える
        RB.AddForce(transform.right * Yoko);        //横方向に力を加える
        RB.AddTorque(-Yoko);                        //回転に変数Yokoのマイナスの力を加える（マイナスだとイイ感じに回転してくれる）
    }
    
}
