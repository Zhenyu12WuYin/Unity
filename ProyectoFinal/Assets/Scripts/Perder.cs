using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Perder : MonoBehaviour
{
    private GameObject texto;
    // Start is called before the first frame update
    void Start()
    {
        texto = GameObject.Find("Mensaje");
        texto.GetComponent<TMP_Text>().SetText("Lástima "+ PlayerPrefs.GetString("Nombre")+"...pero puedes intentarlo de nuevo!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
