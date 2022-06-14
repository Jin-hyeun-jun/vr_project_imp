using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabLayerChange : MonoBehaviour
{
    public void ChangeToGrabLayer(SelectEnterEventArgs args)
    {
        int Layer = LayerMask.NameToLayer("Grab");
        gameObject.layer = Layer;
        if (gameObject.transform.childCount > 0)
        {
            foreach (Transform child in transform)
            {
                child.gameObject.layer = Layer;
            }
        }
        Debug.Log("Current layer: " + gameObject.layer);
    }

    public void ChangeToDefaultLayer(SelectExitEventArgs args)
    {
        int Layer = LayerMask.NameToLayer("Default");
        gameObject.layer = Layer;
        if (gameObject.transform.childCount > 0)
        {
            foreach (Transform child in transform)
            {
                child.gameObject.layer = Layer;
            }
        }
        Debug.Log("Current layer: " + gameObject.layer);
    }
}
