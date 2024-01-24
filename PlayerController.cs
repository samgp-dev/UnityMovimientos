using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
     // Rigidbody del jugador
     private Rigidbody rb; 

     // Movimiento en los ejes X e Y
     private float movementX;
     private float movementY;

     // Velocidad a la que se mueve el jugador
     public float speed = 10; 

     // Texto que muestra la puntuacion
     public TextMeshProUGUI puntuacionText;
     // Variable local de puntuacion
     private int puntuacion;
     // Texto mostrado al completar el objetivo
     public GameObject winTextObject;

     // Start es llamado antes del primer frame
     void Start()
     {
          // Almacena el componente Rigidbody del player
          rb = GetComponent<Rigidbody>();

          puntuacion = 0;

          SetCountText();

          winTextObject.SetActive(false); // Esconde el texto que muestra al ganar
     }

     // Se llama a OnMove cuando se detecta un input de movimiento
     void OnMove(InputValue movementValue)
     {
          // Conviete el valor del input en un 'Vector2' para el movimiento
          Vector2 movementVector = movementValue.Get<Vector2>();

          // Almacena los componentes X e Y del movimiento
          movementX = movementVector.x; 
          movementY = movementVector.y; 
     }
  
     // Se llama a FixedUpdate una vez por frame fijado
     private void FixedUpdate() 
     {
          // Crea vector de movimiento 3D usando los inputs de X e Y
          Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

          // Aplica fuerza al Rigidbody para mover al jugador (duplicado)
          rb.AddForce((movement * speed)*2); 
     }

     // En trigger, colision con 'other'.
     void OnTriggerEnter(Collider other) 
     {
          // Se asugura que el objecto con el que ha colisionado el player tiene el tag "PickUp"
          if (other.gameObject.CompareTag("PickUp")) 
          {
               // Desactiva el objeto con el que ha colisionado (haciendolo desaparecer).
               other.gameObject.SetActive(false);

               puntuacion = puntuacion + 1; // Suma uno a la puntuacion

               SetCountText(); // Actualiza el texto que muestra la puntuacion
          }
     }

     // Metodo que maneja el contenido del texto de puntuacion
     void SetCountText() 
     {
          puntuacionText.text =  "Puntuacion: " + puntuacion.ToString();

          if (puntuacion >= 10)
          {
               winTextObject.SetActive(true); // Muestra el texto de ganar
          }
     }

}