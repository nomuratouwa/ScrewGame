using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void RelordScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    */
    public void PushRetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
