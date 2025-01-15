using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScreenPhoto : MonoBehaviour
{

    private RawImage rawimage;
    private GameObject photo;
    private Snowman snowmanscript;

    void Start()
    {
        rawimage = GetComponent<RawImage>();
        photo = rawimage.gameObject;
        snowmanscript = FindObjectOfType<Snowman>();
        StartCoroutine(Screenshot());
    }

    IEnumerator Screenshot()
    {
        yield return new WaitForEndOfFrame();
        var Screen = ScreenCapture.CaptureScreenshotAsTexture();
        Texture2D newtexture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        newtexture.SetPixels(Screen.GetPixels());
        newtexture.Apply(); 
        rawimage.texture = newtexture;
    }
    public void DeletePhoto()
    {
        Destroy(photo);
    }

    public void SavePhoto()
    {
        Texture2D texture = rawimage.texture as Texture2D;
        if (texture != null)
        {
            byte[] bytes = texture.EncodeToPNG();
            string rnd = Random.Range(0, bytes.Length).ToString();
            string downloadpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), "Downloads");
            string path = Path.Combine(downloadpath, "SnowmanPhoto" + rnd + ".png");
            
            File.WriteAllBytes(path, bytes);
            Debug.Log($"Сохранено {path}");
        }
        else
        {
            Debug.LogError("отсутствует текстура");
        }
    }
}
