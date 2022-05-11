using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaCamera : MonoBehaviour
{
    public Transform jogador;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(jogador.position.x+6, 9.5f, -40);
    }
}