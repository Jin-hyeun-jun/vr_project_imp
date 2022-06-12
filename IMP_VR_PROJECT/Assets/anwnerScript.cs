using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anwnerScript : MonoBehaviour
{
    public GameObject GameObject;
    public void key()
    {
        Instantiate(gameObject, new Vector3(0, 0.5f, 0), Quaternion.identity);
    }
}
