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
        OyaObject = transform.parent.gameObject; //�e�I�u�W�F�N�g�擾
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�N���b�N������
    public void Click() 
    {
        
        switch (Fit)
        {
            case true:          //�O��
                OyaObject.GetComponent<NejiController>().EnabledComponent(this.gameObject);
                this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteNejiana;
                Fit = false;
                break;
            case false:         //�t����
                OyaObject.GetComponent<NejiController>().GyakuEnabledComponent(this.gameObject);
                this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteNeji;
                Fit = true;
                break;
        }
    }


}
