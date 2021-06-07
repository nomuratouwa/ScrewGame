using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageScene : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PushStartButton();
        }
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
