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

    public void PushStartButton()
    {
        SceneManager.LoadScene("StageSelectScene");
    }

    public void RelordScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ClearScene()
    {
        SceneManager.LoadScene("ClearScene");
    }


}
