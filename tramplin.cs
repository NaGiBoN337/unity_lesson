using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tramplin : MonoBehaviour
{
    public float power = 300f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("jump");
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * power);

        }
    }
}
