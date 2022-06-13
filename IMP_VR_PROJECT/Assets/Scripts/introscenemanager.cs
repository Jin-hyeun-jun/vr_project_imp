using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introscenemanager : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource witchvoice;
    void Start()
    {
        witchvoice.Play();
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("gotoscene1",5f);
    }


    void gotoscene1()
    {
        SceneManager.LoadScene("Scene1");
    }
}
