using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeattack : MonoBehaviour
{
    // Start is called before the first frame update
    public float limittime=60.0f;
    public AudioSource witchvoice;

  

    // Update is called once per frame
    void Update()
    {
        limittime -= Time.deltaTime;
        if(limittime==30.0f)
        {
            Debug.Log("30");
            witchvoice.Play();
        }
        if (limittime == 15.0f)
        {
            witchvoice.Play();
        }
        if (limittime == 10.0f)
        {
            witchvoice.Play();
        }
        if (limittime == 5.0f)
        {
            witchvoice.Play();
        }

        if (limittime==0f)
        {
            SceneManager.LoadScene("Ending_Fail");
        }

    }
}
