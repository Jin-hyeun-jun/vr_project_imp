using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeattack : MonoBehaviour
{
    // Start is called before the first frame update
    public float limittime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        limittime -= Time.deltaTime;
        if(limittime==0)
        {

        }
    }
}