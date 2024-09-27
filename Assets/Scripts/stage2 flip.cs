using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2flip : MonoBehaviour
{
    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(-1, 0, 0 * Time.fixedDeltaTime);
    }
}
