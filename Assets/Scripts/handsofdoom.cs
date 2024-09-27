using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handsofdoom : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(-1, 0, 0 * Time.fixedDeltaTime);
    }
}
