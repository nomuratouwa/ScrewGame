using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElekEffectScript : MonoBehaviour
{
    public int ElekTime;      //�d�C�̋���
    private ElectricScript Script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ElekTime > 0)
        {
                ElekTime--;
                transform.Find("LIGHTNING").gameObject.SetActive(true);
        }
        else
        {
            transform.Find("LIGHTNING").gameObject.SetActive(false);

        }

        //�����̂��e�q�֌W�ł����[���h���W�ɌŒ艻����Ă��܂��̂Ń��[�J�����W���Œ肷��
        // transform���擾
        Transform myTransform = this.transform;

        // ���[�J�����W����ɁA���W���擾
        Vector3 localPos = myTransform.localPosition;
        localPos = new Vector3(0, 0, 0);        //���_�ɌŒ�
        myTransform.localPosition = localPos; // ���[�J�����W�ł̍��W��ݒ�
        Vector3 localRot = myTransform.localEulerAngles;
        localRot = new Vector3(0, 0, 0);        //���_�ɌŒ�
        myTransform.localEulerAngles = localRot; //���[�J�����W�ł̉�]��ݒ�
    }
    //���I�u�W�F�N�g���G��Ă����
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Electrical")
        {
            Script = col.gameObject.GetComponent<ElectricScript>();
            ElekTime = Script.ElekTime;         //�ƂȂ�̓d�C�̋������R�s�[����
        }
    }
}
