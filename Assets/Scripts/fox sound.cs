using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxsound : MonoBehaviour
{

    void start()
    {
        
    }

    public void selected()
    {
        AudioSource source = GetComponent <AudioSource>();
        Debug.Log("fox selected");
        source.Play();
    }
}