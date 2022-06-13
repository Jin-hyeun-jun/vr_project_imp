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
        //���� ���ְ� 
        key.SetActive(false);
        //����(Ż�� ����)
        if (successSound != null)
            successSound.Play();
        //success scene���� �Ѿ��
        MyScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("successending", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync(MyScene);

    }
}
