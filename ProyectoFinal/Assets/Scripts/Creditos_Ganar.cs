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
        if (texto != null)
        {
            string nombreJugador = PlayerPrefs.GetString("Nombre");
            string tiempoJugador = PlayerPrefs.GetString("TiempoForm");
            texto.GetComponent<TMP_Text>().SetText("Felicidades " + nombreJugador + ", ganaste la partida en " + tiempoJugador);
        }

        texto = GameObject.Find("Ranking");
        if (texto != null)
        {
            string perfiles="";
            for (int i = 0;i<10;i++)
            {
                if (!(
                    PlayerPrefs.GetString("Nombre"+i).Equals(PlayerPrefs.GetString("Nombre"+(i-1)))
                    && PlayerPrefs.GetFloat("Tiempo" + i) == PlayerPrefs.GetFloat("Tiempo" + (i - 1))
                    ))
                perfiles +=(i+1)+"---"+ PlayerPrefs.GetString("Nombre"+i)+"---"+PlayerPrefs.GetString("TiempoForm"+i)+"\n";
            }
            texto.GetComponent<TMP_Text>().SetText(perfiles);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
