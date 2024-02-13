using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Ganar : MonoBehaviour
{
    [SerializeField] private GameObject contador;
    private float tiempo=0;
    private string tiempoFormateado;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        // Convertir el tiempo a minutos, segundos y milisegundos
        int minutos = Mathf.FloorToInt(tiempo / 60f);
        int segundos = Mathf.FloorToInt(tiempo % 60f);
        int milisegundos = Mathf.FloorToInt((tiempo % 1f) * 1000f);

        // Formatear la salida en formato min:seg:mseg
        tiempoFormateado = string.Format("{0:00}:{1:00}:{2:000}", minutos, segundos, milisegundos);

        // Asignar el texto formateado al componente TMP_Text del contador
        contador.GetComponent<TMP_Text>().text = tiempoFormateado;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && this.gameObject.GetComponent<Renderer>().enabled==true) 
        {
            this.GetComponent<Animator>().SetInteger("Desaparecer", 1);
            Destroy(this.gameObject,0.75f);
            PlayerPrefs.SetString("TiempoForm",tiempoFormateado);
            PlayerPrefs.SetFloat("Tiempo", tiempo);

            float time=0f;
            float aTiempo = tiempo;
            string aNombre = PlayerPrefs.GetString("Nombre");
            string aTiempoForm = tiempoFormateado;
            float bTiempo = tiempo;
            string bNombre = PlayerPrefs.GetString("Nombre");
            string bTiempoForm = tiempoFormateado;
            for (int i = 0; i < 10; i++)
            {
                time = PlayerPrefs.GetFloat("Tiempo" + i);
                if (time == 0f)
                {
                    PlayerPrefs.SetString("Nombre" + i, PlayerPrefs.GetString("Nombre"));
                    PlayerPrefs.SetFloat("Tiempo" + i, tiempo);
                    PlayerPrefs.SetString("TiempoForm" + i, tiempoFormateado);

                } else if (time>aTiempo)
                {
                    bTiempo = PlayerPrefs.GetFloat("Tiempo"+i);
                    bNombre = PlayerPrefs.GetString("Nombre" + i);
                    bTiempoForm = PlayerPrefs.GetString("TiempoForm" + i);


                    PlayerPrefs.SetString("Nombre" + i, aNombre);
                    PlayerPrefs.SetFloat("Tiempo" + i, aTiempo);
                    PlayerPrefs.SetString("TiempoForm" + i, aTiempoForm);

                    aTiempo = bTiempo;
                    aNombre = bNombre;
                    aTiempoForm = bTiempoForm;
                }
                Debug.Log(i);
            }


            SceneManager.LoadScene("Ganar");
        }
    }
}
