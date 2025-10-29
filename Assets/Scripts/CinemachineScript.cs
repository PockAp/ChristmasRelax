using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineScript : MonoBehaviour
{
    public CinemachineVirtualCamera vc0, vc1, vc2, vc3;
    void Start()
    {
        vc0.gameObject.SetActive(false);
        vc1.gameObject.SetActive(false);
        vc2.gameObject.SetActive(true);
        vc3.gameObject.SetActive(false);
    }


    public void StartAnimation()
    {
        StartCoroutine(MoveCamera());
    }

    IEnumerator MoveCamera()
    {
        yield return new WaitForSeconds(2);
        vc1.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        vc0.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        vc3.gameObject.SetActive(true);
    }
}