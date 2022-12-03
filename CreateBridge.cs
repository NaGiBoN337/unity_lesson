using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBridge : MonoBehaviour
{
    public Vector3 PosBridge;
    public Vector3 ScaleBribge;
    private bool open  = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !open)
        {
            open = true;
            GameObject bridge = GameObject.CreatePrimitive(PrimitiveType.Cube);
            bridge.transform.position = PosBridge;
            bridge.transform.localScale = ScaleBribge;

        }
    }
}
