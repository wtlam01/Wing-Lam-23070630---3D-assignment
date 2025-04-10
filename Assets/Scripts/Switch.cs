using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    private bool isIntroduction = true;

    public void OnButtonPress()
    {
        if(isIntroduction)
        {
            SceneManager.LoadScene("fox");
        }else{
            SceneManager.LoadScene("Introduction");
        }

        isIntroduction = !isIntroduction;
    }
}
