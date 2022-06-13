using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VRSceneManager : MonoBehaviour
{
    
    public AudioSource clicksound;
    private Scene MyScene;
    public GameObject Key;
    new Vector3 position;
    private bool checkKey = false;
    public void GotoMainScene()
    {
        MyScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync(MyScene);
    }
    private void Start()
    {
        position = new Vector3(-4, 6, 19);
    }
    private void Update()
    {
        if( Key.gameObject.transform.position.y>4&& Key.gameObject.transform.position.z > 18)
        {
            Debug.Log(Key.gameObject.transform.position);
            checkKey = true;
        }
    }
    public void GotoScene(string sceneName)
    {
        if (checkKey)
        {
            Key.SetActive(false);
            MyScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            SceneManager.UnloadSceneAsync(MyScene);
        }

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