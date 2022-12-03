using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UIElements;

public class teleport : MonoBehaviour
{

    public Vector3 PosExit;

    
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            other.gameObject.transform.position = PosExit;

        }
    }
}
