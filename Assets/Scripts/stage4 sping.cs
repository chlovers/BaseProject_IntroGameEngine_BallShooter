using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage4sping : MonoBehaviour
{


    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(0, 2, 0 * Time.fixedDeltaTime);
    }
}
