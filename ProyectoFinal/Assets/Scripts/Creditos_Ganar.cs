using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Creditos_Ganar : MonoBehaviour
{
    private GameObject texto;
    // Start is called before the first frame update
    void Start()
    {
        texto = GameObject.Find("Ganar");
        string nombreJugador = PlayerPrefs.GetString("Nombre");
        string tiempoJugador = PlayerPrefs.GetString("Tiempo");
        texto.GetComponent<TMP_Text>().SetText("Felicidades "+ nombreJugador+", ganaste la partida en " + tiempoJugador);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
