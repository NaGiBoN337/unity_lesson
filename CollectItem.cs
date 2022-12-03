using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public GameObject collectItem;
    private void Start()
    {
        if (collectItem == null)
        {
            collectItem = this.gameObject;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            Destroy(collectItem);

        }
    }
}
