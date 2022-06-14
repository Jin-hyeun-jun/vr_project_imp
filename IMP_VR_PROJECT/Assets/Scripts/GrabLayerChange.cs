using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabLayerChange : MonoBehaviour
{

    public void ChangeLayer(SelectEnterEventArgs args)
    {
        int Layer = LayerMask.NameToLayer("Grab");
        gameObject.layer = Layer;
        Debug.Log("Current layer: " + gameObject.layer);
    }
}
