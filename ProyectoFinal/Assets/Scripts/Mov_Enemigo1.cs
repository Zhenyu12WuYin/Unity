using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Enemigo1 : MonoBehaviour
{
    private Boolean sentido;
    // Start is called before the first frame update
    void Start()
    {
        sentido = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (sentido)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            this.gameObject.transform.Translate(Vector3.left * Time.deltaTime * 1.5f);
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            this.gameObject.transform.Translate(Vector3.right * Time.deltaTime * 1.5f);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar la etiqueta del objeto con el que colisionó
        if (collision.gameObject.CompareTag("Player"))
        {

        }
        else
        {
            sentido = !sentido;

        }
    }

    private void normalidad()
    {
    }

    
}
