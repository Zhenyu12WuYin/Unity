using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Fondo : MonoBehaviour
{

    [SerializeField] private float velocidad;

    private MeshRenderer imagen;
    // Start is called before the first frame update
    void Start()
    {
        imagen=this.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        imagen.material.mainTextureOffset= new Vector2(Time.time * velocidad, 0);
    }
}
