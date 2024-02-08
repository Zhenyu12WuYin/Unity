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
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            rb.gravityScale = 0f;
            Invoke("normalidad", 0.75f);
        }
        else if (!(collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Cherry")))
        {
            sentido = !sentido;
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            rb.gravityScale = 1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar la etiqueta del objeto con el que colisionó
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            rb.gravityScale = 0f;
            Invoke("normalidad", 0.75f);
        }
        else if (!(collision.gameObject.CompareTag("Floor")||collision.gameObject.CompareTag("Cherry")))
        {
            sentido = !sentido;
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            rb.gravityScale = 1f;
        }
    }

    private void normalidad()
    {
        rb.gravityScale = 1f;
        gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }

}
