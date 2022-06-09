using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introscene : MonoBehaviour
{
    public float limittime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        limittime -= Time.deltaTime;
        if (limittime == 0)
        {
            SceneManager.LoadScene("failending");
        }
    }



}
