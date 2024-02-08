using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambiarEscenas : MonoBehaviour
{

    [SerializeField] private TMP_InputField Nombre;
    [SerializeField] private TMP_Dropdown Dificultad;
    [SerializeField] private TMP_Text Error;


    public void IniciarPartida()
    {

        string nombre = Nombre.text;

        if (nombre.Equals(""))
        {
            Error.GetComponent<TMP_Text>().SetText("Introduce un nombre");
        }

        else
        {
            PlayerPrefs.SetString("Nombre", nombre);

            string dificultad = Dificultad.GetComponentInChildren<TMP_Text>().text;

            PlayerPrefs.SetString("Dificultad", dificultad);

            Error.GetComponent<TMP_Text>().SetText("");

            SceneManager.LoadScene("Escena1");
        }

    }
    public void VolverInicio()
    {
        SceneManager.LoadScene("Inicio");
    }
}
