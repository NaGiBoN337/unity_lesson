using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodytest : MonoBehaviour
{
    public Rigidbody m_body;

    void Start()
    {
        m_body = GetComponent<Rigidbody>();
    }

    void Update()
    {

    } 
    //50 ? ???????
    void FixedUpdate()
    {
            if (Input.GetKey(KeyCode.F))
            {
                m_body.AddForce(-10f, 0f, 0f);
            }

            if (Input.GetKey(KeyCode.G))
            {
                m_body.AddForce(10f, 0f, 0f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                m_body.AddForce(0f, 50f, 0f);
            }

    }
}
