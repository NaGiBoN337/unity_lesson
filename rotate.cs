using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float PerSecond = 5.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
       
        //transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0.8f, 0);
        transform.Rotate(0, PerSecond * Time.deltaTime, 0);      
    }
}
