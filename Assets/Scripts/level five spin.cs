using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelfivespin : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 4, 0 * Time.deltaTime);
    }
}