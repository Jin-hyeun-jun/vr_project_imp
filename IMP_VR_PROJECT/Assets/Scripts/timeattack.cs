using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeattack : MonoBehaviour
{
    // Start is called before the first frame update
    public float limittime;
    AudioSource witchvoice;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        limittime -= Time.deltaTime;
        if(limittime==30.0)
        {
            witchvoice.Play();
        }
        if (limittime == 15.0)
        {
            witchvoice.Play();
        }
        if (limittime == 10.0)
        {
            witchvoice.Play();
        }
        if (limittime == 5.0)
        {
            witchvoice.Play();
        }

        if (limittime==0)
        {
            SceneManager.LoadScene("failending");
        }

    }
}
