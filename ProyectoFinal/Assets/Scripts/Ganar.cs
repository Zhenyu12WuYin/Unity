using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ganar : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && this.gameObject.GetComponent<Renderer>().enabled==true) 
        {
            this.GetComponent<Animator>().SetInteger("Desaparecer", 1);
            Destroy(this.gameObject,0.75f);
        }
    }
}
