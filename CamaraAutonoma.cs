using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraAutonoma : MonoBehaviour
{
    // El método Update se llama una vez por frame
    void Update()
    {
        // Rotar el objeto en los ejes X, Y, Z en cantidades especificas, ajustadas por al frame rate
        transform.Rotate (new Vector3 (0, 0, 20) * Time.deltaTime);
    }
}
