using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BoxCollected.instance.AddBox(value);
            Destroy(this.gameObject);
        }
    }
}
