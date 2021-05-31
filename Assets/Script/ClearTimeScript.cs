using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTimeScript : MonoBehaviour
{
    public Text CleartimeText;
    
    // Start is called before the first frame update
    void Start()
    {
        float Time = TimeScript.GetTime();
        CleartimeText.text = "クリア―タイム　：　" + Time.ToString("f2");
        print(Time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
