using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControladorSample : MonoBehaviour
{
    private GameObject texto;

    // Start is called before the first frame update
    void Start()
    {
        texto = GameObject.Find("Nombre");

        string nombreJugador = PlayerPrefs.GetString("Nombre");

        texto = GameObject.Find("Dificultad");

        string dificultadJugador = PlayerPrefs.GetString("Dificultad");

        texto.GetComponent<TMP_Text>().SetText("Nivel 1     Dificultad: "+dificultadJugador+ "\nPlayer: "+nombreJugador);
    }

}
