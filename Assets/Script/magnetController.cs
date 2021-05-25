using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnetController : MonoBehaviour
{
    [SerializeField] private bool Ziryoku = false;
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
            PointEffector.enabled = true;
            transform.Find("FX_Buff_final").gameObject.SetActive(true);
        }
        else
        {
            PointEffector.enabled = false;
            transform.Find("FX_Buff_final").gameObject.SetActive(false);

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
