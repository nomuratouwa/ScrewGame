using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NejiClick : MonoBehaviour
{
    GameObject OyaObject;
    bool Fit = true;
    [SerializeField] bool Removefrag = false;
    [SerializeField]  bool Naka = false;

    public Sprite SpriteNeji;
    public Sprite SpriteNejiana;

    // Start is called before the first frame update
    void Start()
    {
        OyaObject = transform.parent.gameObject; //親オブジェクト取得
    }

    // Update is called once per frame
    void Update()
    {

    }

    //クリックされると
    public void Click()
    {

        if (Fit && Removefrag)
        {
            OyaObject.GetComponent<NejiController>().HingeEnabledComponent(this.gameObject);
            if (Naka)
                OyaObject.GetComponent<NejiController>().FixedEnabledComponent(this.gameObject);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteNejiana;
            Fit = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            Removefrag = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            Removefrag = false;
        }
    }
}
