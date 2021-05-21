using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnetController : MonoBehaviour
{
    private bool Ziryoku = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var PointEffector = gameObject.GetComponent<PointEffector2D>();
        if (Ziryoku)
        {
            PointEffector.enabled = false;
            Ziryoku = false;
            transform.Find("FX_Buff_final").gameObject.SetActive(false);
        }
        else
        {
            PointEffector.enabled = true;
            Ziryoku = true;
            transform.Find("FX_Buff_final").gameObject.SetActive(true);
        }
    }
    public void MagnetClick()    //ƒNƒŠƒbƒN
    {
        if (Ziryoku)
        {
            Ziryoku = false;
        }
        else
        {
            Ziryoku = true;
        }

    }
}
