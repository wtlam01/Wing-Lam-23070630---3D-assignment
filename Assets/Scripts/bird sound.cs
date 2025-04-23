using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdsound : MonoBehaviour
{
    void start()
    {
        
    }

    public void selected()
    {
        AudioSource source = GetComponent <AudioSource>();
        Debug.Log("bird selected");
        source.Play();
    }
}
