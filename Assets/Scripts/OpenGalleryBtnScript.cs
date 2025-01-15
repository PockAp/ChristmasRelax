using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGalleryBtnScript : MonoBehaviour
{
    public GameObject gallery;
    public GameObject content;
    void Start()
    {
        gallery.SetActive(false);
    }

    public void FindPhoto()
    {
        GameObject[] photos;
        photos = GameObject.FindGameObjectsWithTag("ScreenTag");
        foreach (GameObject photo in photos)
        {
            photo.transform.SetParent(content.transform, false);
        }
    }
}
