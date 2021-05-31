using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSoundManager : MonoBehaviour
{
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
    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();  // Œø‰Ê‰¹‚ğ–Â‚ç‚·
    }
}