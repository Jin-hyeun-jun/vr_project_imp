using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveLetter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject B;
    public GameObject L;
    public GameObject U;
    public GameObject E;
  
    public void activeb()
    {
        B.SetActive(true);
    }
    public void activel()
    {
        L.SetActive(true);
    }
    public void activeu()
    {
        U.SetActive(true);
    }
    public void activee()
    {
        E.SetActive(true);
    }
}
