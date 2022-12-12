using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    public GameObject prefab;
    private float T = 0;

    // Update is called once per frame
    void Update()
    {
        T += Time.deltaTime;
        if (T >= 1)
        {
            GameObject new_block = Instantiate(prefab);
            new_block.transform.position = transform.position;
            T = 0;
            Destroy(new_block, 3);
        }
    }
}
