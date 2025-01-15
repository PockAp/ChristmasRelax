using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakePhoto : MonoBehaviour
{
    public GameObject panelphotogallery;
    public GameObject uipanelobjects;
    public RawImage prefabphoto;
    public AudioSource clicksound;

    public void OpenPhotoScreen()
    {
        uipanelobjects.SetActive(false);
        panelphotogallery.SetActive(true);
    }

    public void ClosePhotoScreen()
    {
        uipanelobjects.SetActive(true);
        panelphotogallery.SetActive(false);
    }

    public void MakeNewPhoto()
    {
        OpenPhotoScreen();
        Instantiate(prefabphoto);
        clicksound.Play();
        Invoke("ClosePhotoScreen", 1);
    }
}
