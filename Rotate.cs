using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float PerSecond = 5.0f;


    
    private void FixedUpdate()
    {
        transform.Rotate(0, PerSecond * Time.deltaTime, 0);
    }
}
