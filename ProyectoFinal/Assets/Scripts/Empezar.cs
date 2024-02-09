using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empezar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("cambiarEstado", 0.5f);
    }

    // Update is called once per frame
    void cambiarEstado()
    {
        this.gameObject.GetComponent<Animator>().SetInteger("Checkpoint", 1);
    }
}
