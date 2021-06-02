using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otoPitch : MonoBehaviour
{
    public AudioSource audioSource;
    private int Cnt1;
    private float pitch=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cnt1++;
        if (Cnt1 > 25)
        {
            Cnt1 = 0;
            audioSource.pitch =  Random.Range( -pitch, pitch) ;
        }
    }
}
