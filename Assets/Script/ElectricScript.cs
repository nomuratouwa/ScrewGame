using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricScript : MonoBehaviour
{
    public int ElekTime = 100;      //�d�C�̋����@�@�l���傫���Ɠ`�����₷���Ȃ�
    public  bool Minamoto = false;      //�������ǂ���
    [SerializeField] private bool EffectFrag = false;
    [SerializeField] private bool Debug = false;
    public Sprite Sunder;               //�f�o�b�N�p�d�C�̃X�v���C�g
    private ElectricScript Script;
    // Start is called before the first frame update
    void Start()
    {

        this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (ElekTime>0)
        {
            this.tag = "Electrical";            //�^�O������
            if(Debug)
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sunder;
            if (!Minamoto)
                ElekTime--;
        }
        else
        {
            this.tag = "Untagged";              //�^�O���O��
            if(Debug)
                this.gameObject.GetComponent<SpriteRenderer>().sprite = null;  //�f�o�b�N�p
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
            //Debug.Log("Test!!!!!!!!");
            Script = col.gameObject.GetComponent<ElectricScript>();
            if (Script.ElekTime > 0 && !Minamoto && !EffectFrag)
            {
                ElekTime = Script.ElekTime;         //�ƂȂ�̓d�C�̋������R�s�[����
            }
            if (EffectFrag)
            {
                transform.Find("LIGHTNING").gameObject.SetActive(true);
            }
        }else if (EffectFrag)
        {
            transform.Find("LIGHTNING").gameObject.SetActive(false);
        }
    }
}
