using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelfivespin : MonoBehaviour
{


    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(0, 2, 0 * Time.fixedDeltaTime);
    }
}
