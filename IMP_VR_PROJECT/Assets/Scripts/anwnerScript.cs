using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anwnerScript : MonoBehaviour
{
    GameObject answer;
    public GameObject GameObject;

    public void key()
    {
        Debug.Log("key!");
        answer=Instantiate(gameObject, new Vector3(1,1,1), Quaternion.identity);
        
    }
}
