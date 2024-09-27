using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{


    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(0, 1 , 0 * Time.fixedDeltaTime);
    }
   
}
