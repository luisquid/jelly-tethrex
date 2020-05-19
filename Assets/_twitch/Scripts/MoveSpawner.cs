//Made by SquidBait
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawner : MonoBehaviour
{
    public float movementSpeed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 inputDirection = new Vector2(Input.GetAxis("Horizontal"), 0.0f);
        transform.position = transform.position + (Vector3)inputDirection * Time.deltaTime * movementSpeed;
    }
}
