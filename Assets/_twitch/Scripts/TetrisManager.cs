//Made by SquidBait
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisManager : MonoBehaviour
{
    public GameObject[] HexPieces;
    public Transform spawnPosition;
    public float timeToSpawn = 1f;

    void Start()
    {
        StartCoroutine(SpawnPiece());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnPiece()
    {
        Instantiate(HexPieces[Random.Range(0, HexPieces.Length)], spawnPosition.position, Quaternion.identity);
        yield return new WaitForSeconds(timeToSpawn);
        StartCoroutine(SpawnPiece());
    }
}
