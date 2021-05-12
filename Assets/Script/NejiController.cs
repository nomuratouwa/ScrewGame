using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NejiController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject RightNejiObject = GameObject.Find("RightNeji");  //�E�˂�object�擾
        GameObject LeftNejiObject = GameObject.Find("LeftNeji");    //���˂�object�擾

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void EnabledComponent(GameObject gameObject)    //�q���Q�W���C���g����
    {
        var HingeJoint = gameObject.GetComponent<HingeJoint2D>();
        HingeJoint.enabled = false;
    }

    public void GyakuEnabledComponent(GameObject gameObject)   //�q���Q�W���C���g�L��
    {
        var HingeJoint = gameObject.GetComponent<HingeJoint2D>();
        HingeJoint.enabled = true;
    }
}
