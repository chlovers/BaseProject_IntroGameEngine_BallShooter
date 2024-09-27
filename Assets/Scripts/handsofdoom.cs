using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handsofdoom : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0.2f, 0, 0 * Time.deltaTime);
    }
}
