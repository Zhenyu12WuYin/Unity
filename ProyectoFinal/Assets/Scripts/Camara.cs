using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform objetivo; // El objeto que la c�mara debe seguir

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objetivo != null)
        {
            // Obtener la posici�n actual de la c�mara
            Vector3 posicionActual = transform.position;

            // Obtener la posici�n del objetivo (personaje)
            Vector3 posicionObjetivo = objetivo.position;

            // Mantener la misma posici�n en Z (profundidad)
            posicionObjetivo.z = posicionActual.z;

            // Establecer la nueva posici�n de la c�mara interpolando su posici�n actual hacia la posici�n del objetivo
            transform.position = Vector3.Lerp(posicionActual, posicionObjetivo, Time.deltaTime * 5f);
        }
    }
}
