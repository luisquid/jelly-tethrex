//Made by SquidBait
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnd : MonoBehaviour
{
    public float explosionForce = 1000f;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Piece"))
        {
            Debug.Log("I AM HERE");
            other.transform.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, other.transform.position, 15f);
        }
    }
}
