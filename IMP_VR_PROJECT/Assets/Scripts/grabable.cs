using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class grabable : MonoBehaviour
{
    public GameObject cup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void getcupgrab()
    {
        cup.GetComponent<XRGrabInteractable>();
    }
}
