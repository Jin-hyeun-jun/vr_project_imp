using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeattack : MonoBehaviour
{
    // Start is called before the first frame update
    public float limittime=60f;
    public AudioSource witchvoice;


    int i = 0;
    // Update is called once per frame
    void Update()
    {
        limittime -= Time.deltaTime;
        if (limittime < 13.5f && i == 0)
        {
           
            witchvoice.Play();
            i++;
        }
       

        if (limittime<0)
        {
            SceneManager.LoadScene("Ending_Fail");
        }

    }
}
