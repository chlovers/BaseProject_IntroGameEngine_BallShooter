using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipper : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-1, 0, 0 * Time.deltaTime);
    }
}
