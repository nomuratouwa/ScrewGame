using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuiteku : MonoBehaviour
{
    [SerializeField] GameObject TuitekuObject;  //���Ă��������I�u�W�F�N�g

    void LateUpdate()
    {
        // transform���擾
        Transform myTransform = this.transform;
        // ���[�J�����W����ɁA���W���擾
        Vector3 localPos = myTransform.localPosition;
        Vector3 TuitekuPos = TuitekuObject.transform.localPosition;//���Ă��I�u�W�F�N�g�̍��W�擾
        localPos =  TuitekuPos;        //���Ă��I�u�W�F�N�g�̍��W�Ɏw��
        myTransform.localPosition = localPos; // �����̃��[�J�����W��ς���

    }
}
