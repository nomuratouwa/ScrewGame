using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSoundManager : MonoBehaviour
{
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
    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();  // 効果音を鳴らす
    }
}