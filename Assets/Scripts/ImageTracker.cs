using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation; // include xr library

public class TrackImage : MonoBehaviour
{
    [SerializeField]
    ARTrackedImageManager m_TrackedImageManager; 
    public GameObject foxPrefab; //Prefab you want to appear on marker image
    
    void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        // When the camera picks up a new image marker Unity adds a game object to it called newImage, this will stick to maker.
        foreach (ARTrackedImage newImage in eventArgs.added)
        {
           GameObject newObject = GameObject.Instantiate(foxPrefab);


            newObject.transform.SetParent(newImage.transform, false);

           // Vector3 position = newImage.transform.position;

           // newObject.transform.position = position;

          //  Quaternion rotation = newImage.transform.rotation * Quaternion.Euler(0, 90, 0); 


        }
    }
}
