using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuiteku : MonoBehaviour
{
    [SerializeField] GameObject TuitekuObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void LateUpdate()
    {
        // transform���擾
        Transform myTransform = this.transform;
        // ���[�J�����W����ɁA���W���擾
        Vector3 localPos = myTransform.localPosition;
        Vector3 TuitekuPos = TuitekuObject.transform.localPosition;
        localPos =  TuitekuPos;        //���W�w��
        myTransform.localPosition = localPos; // ���[�J�����W�ł̍��W��ݒ�
    }
}
