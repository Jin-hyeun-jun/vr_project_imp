using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Linq;

public class Scene2PasswordController : MonoBehaviour
{
    public AudioSource buttonPressed;
    private List<int> answer = new List<int>() {4,9,1,8};
    private List<int> pressedPassword = new List<int>();

    public GameObject chest_open;
    public GameObject chest_closed;
    public GameObject key;

    public AudioSource checkSound;
    public AudioClip success;
    public AudioClip fail;

    public void PlayButtonPressedSound(SelectEnterEventArgs args)
    {
        if (buttonPressed != null)
            buttonPressed.Play();
    }

    public void OnPressed(SelectExitEventArgs args)
    {
        if (args.interactableObject.transform.gameObject.tag == "Password")
        {
            GameObject pressedButton = args.interactableObject.transform.gameObject;

            if (pressedButton.name == "Reset")
                pressedPassword.Clear();

            else if (pressedButton.name == "Check")
            {
                bool check = pressedPassword.SequenceEqual(answer);
                if (check)
                {
                    if (checkSound != null && success != null)
                        checkSound.clip = success;
                    chest_closed.SetActive(false);
                    chest_open.SetActive(true);
                    key.SetActive(true);
                }
                else
                {
                    if (checkSound != null && fail != null)
                        checkSound.clip = fail;
                }
                checkSound.Play();
            }

            else
            {
                int pressedNum = int.Parse(pressedButton.name);
                pressedPassword.Add(pressedNum);
                Debug.Log(pressedNum);
            }
        }

    }

}
