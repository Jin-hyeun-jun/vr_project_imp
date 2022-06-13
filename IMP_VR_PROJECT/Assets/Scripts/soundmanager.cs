using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{

    public AudioSource endingsound;
    public float endtime;
    // Start is called before the first frame update
    void Start()
    {
        endingsound.Play();
        Invoke("end", endtime);
    }

    void end()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
    // Update is called once per frame

}
