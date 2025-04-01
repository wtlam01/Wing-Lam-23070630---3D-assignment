using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotSay : MonoBehaviour
{
       bool annotation2Visible = false; //current visibility of ship
    public GameObject annotation2; // annotation object





    public void selected()
    {




        Debug.Log("show annotation2");
        //toggle visibility of the annotation
        if (annotation2Visible)
        {
            annotation2.SetActive(false);
            annotation2Visible = false;
        }else {
            annotation2.SetActive(true);
            annotation2Visible = true;
        }
    }

}

