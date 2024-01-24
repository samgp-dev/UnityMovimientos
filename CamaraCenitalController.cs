using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraCenitalController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    void Update()
    {
        // Mapea los controles 
        if(Input.GetKey(KeyCode.UpArrow)) // Si se presiona la tecla 'W'
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime); // Su posicion cambia
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

}
