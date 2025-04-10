using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnFire : MonoBehaviour
{
    public GameObject fire1;
    public GameObject fire2;
    public GameObject fire3;

    private int clickCount = 0;

    public void OnButtonClick()
    {
        fire1.SetActive(false);
        fire2.SetActive(false);
        fire3.SetActive(false);

        if (clickCount == 0)
        {
            fire1.SetActive(true);
            fire2.SetActive(true);
            fire3.SetActive(true);
            Debug.Log("destroyforest");
       }
    }
}