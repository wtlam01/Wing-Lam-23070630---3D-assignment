using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_Interactions : MonoBehaviour
{
     bool annotationVisible = false; //current visibility of ship
    public GameObject annotation; // annotation object

    public void selected()
    {

        Debug.Log("show annotation");
        //toggle visibility of the annotation
        if (annotationVisible)
        {
            annotation.SetActive(false);
            annotationVisible = false;
        }else {
            annotation.SetActive(true);
            annotationVisible = true;
        }

    }
}
