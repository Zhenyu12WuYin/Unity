using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Enemigo : MonoBehaviour
{
    private Boolean sentido;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        sentido = true;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sentido)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            this.gameObject.transform.Translate(Vector3.left * Time.deltaTime * 1.5f);
        } else
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            this.gameObject.transform.Translate(Vector3.right * Time.deltaTime * 1.5f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar la etiqueta del objeto con el que colisionó
        if (!collision.gameObject.CompareTag("Floor"))
        {
            sentido = !sentido;
        }
    }
        
}
