using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Scene2Player : MonoBehaviour
{

    private bool clue2filped = false;
    public void OnShot(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.gameObject.tag == "sc2clue2")
        {
            //y가 - 180, z가 - 60 아닐때는 z가 -120
            GameObject myclue = args.interactableObject.transform.gameObject;

            if (!clue2filped)
            {
                myclue.transform.eulerAngles = new Vector3(0, -180, -60);
                clue2filped = true;
            } else
            {
                myclue.transform.eulerAngles = new Vector3(0, 0, -120);
                clue2filped = false;
            }


            //Destroy(args.interactableObject.transform.gameObject);
        }

    }

}
