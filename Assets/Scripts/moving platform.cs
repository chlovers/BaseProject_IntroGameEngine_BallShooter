using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    [SerializeField] GameObject pointA;
    [SerializeField] GameObject pointB;
    [SerializeField] float speed = 10f;
    [SerializeField] float delay = 1f;
    [SerializeField] GameObject platform;
    [SerializeField] bool startMoving = true;

    private bool alreadyMoving = false;

    private Vector3 targetPosition;

     void Start()
    {
        platform.transform.position = pointB.transform.position;
        targetPosition = pointA.transform.position;
    }

    public void StartMoving()
    {



    }

}



// https://www.youtube.com/watch?v=evlHquYm9ME
