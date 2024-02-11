using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Zorro : MonoBehaviour
{
    Animator animacion;
    private Rigidbody2D rb;
    private Vida vida;
    private Extra extra;
    void Start()
    {
        
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        animacion = this.gameObject.GetComponent<Animator>();
        vida= GetComponent<Vida>();
        extra = GetComponent<Extra>();
    }

    void Update()
    {

        //Estados de animación
        if (rb.velocity.y > 0)
            animacion.SetInteger("Estado", 2);
        else if (rb.velocity.y < 0)
            animacion.SetInteger("Estado", 3);
        else
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                animacion.SetInteger("Estado", 1);
            else
                animacion.SetInteger("Estado", 0);
        }



        //Movimientos
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX= true;
            this.gameObject.transform.Translate(Vector3.left * Time.deltaTime* 3f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            this.gameObject.transform.Translate(Vector3.right * Time.deltaTime* 3f);
        }
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y==0)
        {
            rb.AddForce(Vector2.up * 7f, ForceMode2D.Impulse);
        }


    }


    /* No funciona la animación de daño
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            animacion.SetInteger("Estado", 4);
            Invoke("Update", 2f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            animacion.SetInteger("Estado", 4);
            Invoke("Update", 2f);
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            vida.PerderVida();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Animator AnimCherry = collision.gameObject.GetComponent<Animator>();
            extra.MasExtra();
            AnimCherry.SetInteger("Desaparecer", 1);
            Destroy(collision.gameObject, 0.5f);
        }
        else if (collision.gameObject.CompareTag("Enemy"))
            vida.PerderVida();
    }
}
