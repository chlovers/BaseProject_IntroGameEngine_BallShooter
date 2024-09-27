using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuprotate : MonoBehaviour
{


    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(0,0 , 1 * Time.fixedDeltaTime);
    }
}
