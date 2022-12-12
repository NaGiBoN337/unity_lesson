using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load_new_lvl : MonoBehaviour
{
    public float t = 0f;
    private bool ontriger = false;

    
    void Update()
    {
        if (ontriger)
        {
            t += Time.deltaTime;
            if (t >= 3)
            {
                Application.LoadLevel("Second");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {   
        ontriger = true;     
    }
}
