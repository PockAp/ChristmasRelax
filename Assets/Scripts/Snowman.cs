using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Snowman : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject leg;
    public ParticleSystem particlessnow;
    public TextMeshProUGUI numberhead;
    public TextMeshProUGUI numberbody;
    public TextMeshProUGUI numberleg;
    public AudioSource backgroundmusic;
    public List<AudioClip> musiclist;
    public List<GameObject> allhats;
    public List<GameObject> legballs;
    public List<GameObject> allnoses;
    public List<GameObject> allitems;
    public TextMeshProUGUI textname;
    public List<Color> allcolors;
    public TMP_InputField inputwish;
    public TextMeshProUGUI textwish;
    public TMP_InputField inputname;

    void Start()
    {

    }

    public void SetCap(int index)
    {
        for (int i = 0; i < allhats.Count; i++)
        {
            if (i == index)
            {
                allhats[i].SetActive(true);
            }

            else
            {
                allhats[i].SetActive(false);
            }
        }
    }

    public void ToggleMusic(bool lemon)
    {
        backgroundmusic.mute = !lemon;
    }

    public void Music(int index)
    {
        for (int i = 0; i < musiclist.Count; i++)
        {
            if (i == index)
            {
                backgroundmusic.clip = musiclist[i];
                backgroundmusic.Play();
            }
        }
    }

    public void SetNameSnowman(string name)
    {
        textname.text = name;
    }

    public void SetHeadSize(float value)
    {
        head.transform.localScale = new Vector3(value, value, value);
        numberhead.text = head.transform.localScale.y.ToString("0.0");
    }

    public void SetWishText(string text)
    {
        textwish.text = text;
    }

    public void SetHandItem(int index)
    {
        for (int i = 0; i < allitems.Count; i++)
        {
            if (i == index)
            {
                allitems[i].SetActive(true);
            }

            else
            {
                allitems[i].SetActive(false);
            }
        }
    }

    public void SetBodySize(float value)
    {
        body.transform.localScale = new Vector3(value, value, value);
        numberbody.text = body.transform.localScale.y.ToString("0.0");
    }


    public void SetColourName(int index)
    {
        string name = textname.text;
        textname.color = allcolors[index];
        inputname.image.color = allcolors[index];
        textname.text = name;
    }


    public void SetLegBall(int index)
    {
        for (int i = 0; i < legballs.Count; i++)
        {
            if (i == index)
            {
                legballs[i].SetActive(true);
            }

            else
            {
                legballs[i].SetActive(false);
            }
        }
    }
    public void SetNose(int index)
    {
        for (int i = 0; i < allnoses.Count; i++)
        {
            if (i == index)
            {
                allnoses[i].SetActive(true);
            }

            else
            {
                allnoses[i].SetActive(false);
            }
        }
    }

    public void SetLegSize(float value)
    {
        leg.transform.localScale = new Vector3(value, value, value);
        numberleg.text = leg.transform.localScale.y.ToString("0.0");
    }

    public void SnowActivate(bool trueorfalse)
    {
       if(trueorfalse == true)
        {
            particlessnow.Play();
        }
        else
        {
            particlessnow.Stop();
        }
    }

    //void Update()
    //{

    //}
}
