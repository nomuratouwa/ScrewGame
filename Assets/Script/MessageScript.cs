using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageScript : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float FeedTime = 0.01f;

    private bool PlayerHantei = false;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup.alpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHantei)
        {
            if (canvasGroup.alpha < 1.0f)
                canvasGroup.alpha += FeedTime;
        }
        else
        {
            if (canvasGroup.alpha > 0.0f)
                canvasGroup.alpha -= FeedTime;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            PlayerHantei = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            PlayerHantei = false;
        }
    }
}
