using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToSnowman : MonoBehaviour
{
    public Transform target; // target = ����


    void Update()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}
