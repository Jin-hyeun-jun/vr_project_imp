using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;


public class DoorSocketController : MonoBehaviour
{
    public AudioSource successSound;
    public GameObject key;
    private Scene MyScene;

    public void SocketSuccess(SelectEnterEventArgs args)
    {
        //열쇠 없애고 
        key.SetActive(false);
        //사운드(탈출 성공)
        if (successSound != null)
            successSound.Play();
        //success scene으로 넘어가기
        MyScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("successending", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync(MyScene);

    }
}
