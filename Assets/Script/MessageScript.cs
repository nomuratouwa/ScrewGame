using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            transform.Find("Panel").gameObject.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            transform.Find("Panel").gameObject.SetActive(false);
        }
    }
}
