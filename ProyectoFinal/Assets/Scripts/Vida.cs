using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{

    public int vidaActual;
    public int vidaTotal;

    [SerializeField] Image[] corazones;
    [SerializeField] Sprite fullHeart;
    [SerializeField] Sprite emptyHeart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (vidaActual>vidaTotal)
        {
            vidaActual = vidaTotal;
        }

        for (int i = 0; i < corazones.Length; i++)
        {
            if (i< vidaActual)
            {
                corazones[i].sprite = fullHeart;
            } else
            {
                corazones[i].sprite = emptyHeart;
            }

            if (i < vidaTotal)
            {
                corazones[i].enabled = true;
            }
            else
            {
                corazones[i].enabled = false;

            }
        }
    }

    public void PerderVida()
    {
        vidaActual--;
    }
}
