using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NejiClick : MonoBehaviour
{
    public GameObject NejiPrefab;

    GameObject OyaObject;
    GameObject PlayerObject;
    bool Fit = true;                            //�˂����͂܂��Ă��邩�ǂ���
    [SerializeField] bool Removefrag = false;   //�߂��Ɏ�l�������邩
    [SerializeField] bool Naka = false;         //�Ȃ��̂˂���

    public Sprite SpriteNeji;
    public Sprite SpriteNejiana;
    
    void Start()
    {
        OyaObject = transform.parent.gameObject; //�e�I�u�W�F�N�g�擾
        PlayerObject = GameObject.Find("driver");//�v���C���[�I�u�W�F�N�g�擾
    }

    //�N���b�N������
    public void Click()
    {

        if (Fit && Removefrag)
        {
            PlayerObject.GetComponent<PlayerController>().SpinAnim();                           //��l���ɉ��A�j���[�V������������
            OyaObject.GetComponent<NejiController>().HingeEnabledComponent(this.gameObject);        //�q���Q�W���C�����g�𖳌��ɂ�����
            if (Naka)
                OyaObject.GetComponent<NejiController>().FixedEnabledComponent(this.gameObject);    //���Ȃ�t�B�N�Z�h�W���C���g������
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteNejiana;                  //
            GameObject HazushiNeji = Instantiate(NejiPrefab, transform.position, Quaternion.identity);//�˂���΂��v���n�u
            Fit = false;                                                                            //�l�W���͂���
        }
    }

    void OnTriggerEnter2D(Collider2D col)           //�v���C���[���߂��ɂ��邩
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
