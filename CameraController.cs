using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Referencia el player
    public GameObject player;

    // Distancia entra camara y player
    private Vector3 offset;

    // Start es llamado antes que el primer frame
    void Start()
    {
        // Calcula la diferencia entre la posicion de la camara y la del jugador
        offset = transform.position - player.transform.position; 
    }

    // LateUpdate es llamado una vez por frame despues de las funciones Update
    void LateUpdate()
    {
        // Mantener la diferencia entre camara y jugador a lo largo del juego
        transform.position = player.transform.position + offset;  
        // Mantener la MISMA rotacion entre camara y jugador 
        transform.rotation = player.transform.rotation;

    }
}