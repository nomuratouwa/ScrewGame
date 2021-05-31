using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource Source;//AudioSource

    [SerializeField] private AudioClip Clip1;//効果音1 足音
    [SerializeField] private AudioClip Clip2;//効果音2 Ω＼ζ°)ﾁｰﾝ
    /*
    // Update is called once per frame
    void Update()
    {
        // 横移動したら、効果音を鳴らす
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }

        // 横移動したら、効果音を鳴らす(長押しした場合)
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }
    }*/
    public void PlaySound1()
    {
        Source.PlayOneShot(Clip1);  // 効果音を鳴らす
    }
    public void PlaySound2()
    {
        Source.PlayOneShot(Clip2);  // 効果音を鳴らす
    }
}