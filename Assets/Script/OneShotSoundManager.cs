using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource Source;//AudioSource

    [SerializeField] private AudioClip Clip1;//Œø‰Ê‰¹1 ‘«‰¹
    [SerializeField] private AudioClip Clip2;//Œø‰Ê‰¹2 ƒ¶_ƒÄ‹)Á°İ
    /*
    // Update is called once per frame
    void Update()
    {
        // ‰¡ˆÚ“®‚µ‚½‚çAŒø‰Ê‰¹‚ğ–Â‚ç‚·
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            GetComponent<AudioSource>().Play();  // Œø‰Ê‰¹‚ğ–Â‚ç‚·
        }

        // ‰¡ˆÚ“®‚µ‚½‚çAŒø‰Ê‰¹‚ğ–Â‚ç‚·(’·‰Ÿ‚µ‚µ‚½ê‡)
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            GetComponent<AudioSource>().Play();  // Œø‰Ê‰¹‚ğ–Â‚ç‚·
        }
    }*/
    public void PlaySound1()
    {
        Source.PlayOneShot(Clip1);  // Œø‰Ê‰¹‚ğ–Â‚ç‚·
    }
    public void PlaySound2()
    {
        Source.PlayOneShot(Clip2);  // Œø‰Ê‰¹‚ğ–Â‚ç‚·
    }
}