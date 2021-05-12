using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricScript : MonoBehaviour
{
    public int ElekTime = 100;
    public  bool Minamoto = false;
    public Sprite Sunder;
    private ElectricScript Script;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ElekTime>0)
        {
            this.tag = "Electrical";
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sunder;
            if (!Minamoto)
                ElekTime--;
        }
        else
        {
            this.tag = "Untagged";
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }

        // transform���擾
        Transform myTransform = this.transform;

        // ���[�J�����W����ɁA���W���擾
        Vector3 localPos = myTransform.localPosition;
        localPos.x = 0.0f;    // ���[�J�����W����ɂ����Ax���W�������Ă���ϐ�
        localPos.y = 0.0f;    // ���[�J�����W����ɂ����Ay���W�������Ă���ϐ�
        localPos.z = 0.0f;    // ���[�J�����W����ɂ����Az���W�������Ă���ϐ�
        myTransform.localPosition = localPos; // ���[�J�����W�ł̍��W��ݒ�
    }

    //���I�u�W�F�N�g���G��Ă����
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Electrical")
        {
            Debug.Log("Test!!!!!!!!");
            Script = col.gameObject.GetComponent<ElectricScript>();
            if (Script.ElekTime > 0 && !Minamoto)
            {
                ElekTime = Script.ElekTime;
            }

        }
    }
}
