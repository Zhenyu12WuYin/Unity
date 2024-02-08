using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform objetivo; // El objeto que la cámara debe seguir

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objetivo != null)
        {
            // Obtener la posición actual de la cámara
            Vector3 posicionActual = transform.position;

            // Obtener la posición del objetivo (personaje)
            Vector3 posicionObjetivo = objetivo.position;

            // Mantener la misma posición en Z (profundidad)
            posicionObjetivo.z = posicionActual.z;

            // Establecer la nueva posición de la cámara interpolando su posición actual hacia la posición del objetivo
            transform.position = Vector3.Lerp(posicionActual, posicionObjetivo, Time.deltaTime * 5f);
        }
    }
}
