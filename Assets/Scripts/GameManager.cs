using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameinterfeis;
    public CinemachineScript scriptcinem;
    public Button startbttn;
    void Start()
    {
       gameinterfeis.SetActive(false); 
    }

    public void UIInterfaceActivate()
    {
        gameinterfeis.SetActive(true);
    }
    public void StartBtnAnimationStart()
    {
        startbttn.gameObject.SetActive(false);
        scriptcinem.StartAnimation();
        Invoke("UIInterfaceActivate", 10);
    }
}
