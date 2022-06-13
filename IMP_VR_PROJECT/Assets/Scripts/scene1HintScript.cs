using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene1HintScript : MonoBehaviour
{
    public GameObject hintPage;

    public void ClickHint()
    {
        hintPage.SetActive(true);
    }

    public void ClickClose()
    {
        hintPage.SetActive(false);
    }

}
