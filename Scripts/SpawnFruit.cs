using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public GameObject[] vetor;
    public float Spmin, Spmax;
    public float maxY, minY;

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        Instantiate(vetor[Random.Range(0, vetor.Length)], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(Spmin, Spmax));

        // seta nova posição do spawner
        Vector3 npos = new Vector3(transform.position.x, Random.Range(minY, maxY), -5);
        transform.position = npos;
    }
}
