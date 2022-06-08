using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VRSceneManager : MonoBehaviour
{
    public AudioSource clicksound;
    private Scene MyScene;
    public void GotoMainScene()
    {
        MyScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync(MyScene);
    }

    public void GotoScene(string sceneName)
    {
        MyScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync(MyScene);


    }
 /*   public void soundclick()
    {
        clicksound.Play();
    }

    int ClickCount = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClickCount++;
        }
        else if (ClickCount == 2)
        {
            CancelInvoke("DoubleClick");
            Application.Quit();
        }
    }
 */

}