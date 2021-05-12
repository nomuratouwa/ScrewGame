using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NejiClick : MonoBehaviour
{
    GameObject OyaObject;
    bool Fit = true;

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
        
        switch (Fit)
        {
            case true:          //外す
                OyaObject.GetComponent<NejiController>().EnabledComponent(this.gameObject);
                this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteNejiana;
                Fit = false;
                break;
            case false:         //付ける
                OyaObject.GetComponent<NejiController>().GyakuEnabledComponent(this.gameObject);
                this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteNeji;
                Fit = true;
                break;
        }
    }


}
