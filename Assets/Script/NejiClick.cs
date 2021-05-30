using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NejiClick : MonoBehaviour
{
    public GameObject NejiPrefab;

    GameObject OyaObject;
    GameObject PlayerObject;
    bool Fit = true;
    [SerializeField] bool Removefrag = false;
    [SerializeField] bool Naka = false;

    public Sprite SpriteNeji;
    public Sprite SpriteNejiana;

    // Start is called before the first frame update
    void Start()
    {
        OyaObject = transform.parent.gameObject; //親オブジェクト取得
        PlayerObject = GameObject.Find("driver");
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
            Debug.Log("aaa");
            PlayerObject.GetComponent<PlayerController>().SpinAnim();
            OyaObject.GetComponent<NejiController>().HingeEnabledComponent(this.gameObject);
            if (Naka)
                OyaObject.GetComponent<NejiController>().FixedEnabledComponent(this.gameObject);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteNejiana;
            GameObject HazushiNeji = Instantiate(NejiPrefab, transform.position, Quaternion.identity);
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
