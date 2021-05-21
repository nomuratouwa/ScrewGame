using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuhukuScript : MonoBehaviour
{

    public float speed = 0.05f;
    public int Kyori = 100;
    public bool Yoko = true;
    public bool Tate = true;
    int count = 0;

    void Update()
    {
        Vector3 vec3 = new Vector3(0, 0, 0); ;
        if (Yoko)
            vec3 = new Vector3(speed, 0, 0);
        if(Tate)
            vec3 = new Vector3(0, speed, 0);
        transform.Translate(vec3);
        count++;

        //count‚ª100‚É‚È‚ê‚Î-1‚ðŠ|‚¯‚Ä‹t•ûŒü‚É“®‚©‚·
        if (count == Kyori)
        {
            count = 0;
            speed *= -1;
        }
    }
}
