using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnime : MonoBehaviour
{
    public GameObject NejiPrefab;
//    bool Fit = true;
    public Sprite SpriteNeji;
    public Sprite SpriteNejiana;

    //�N���b�N������
    public void Click()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteNejiana;
        GameObject HazushiNeji = Instantiate(NejiPrefab, transform.position, Quaternion.identity);
//        Fit = false;
    }
}