using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class try_Button : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    private int clickCount = 0;

    public void OnButtonClick()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);

        if (clickCount == 0)
        {
            text1.SetActive(false);
            text2.SetActive(true);
            text3.SetActive(false);
            Debug.Log("NoClick");
       }
        if (clickCount == 1)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(true);
            Debug.Log("FirstClick");
        }

        clickCount ++;
    }
}
