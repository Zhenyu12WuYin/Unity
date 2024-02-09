using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Extra : MonoBehaviour
{
    public int extraActual;
    public int extraTotal;

    [SerializeField] Image[] extras;
    [SerializeField] Sprite cherry;
    [SerializeField] Sprite empty;

    [SerializeField] GameObject final;

    // Start is called before the first frame update
    void Start()
    {
        final.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (extraActual > extraTotal)
        {
            extraActual = extraTotal;
        }

        for (int i = 0; i < extras.Length; i++)
        {
            if (i < extraActual)
            {
                extras[i].sprite = cherry;
            }
            else
            {
                extras[i].sprite = empty;
            }

            if (i < extraTotal)
            {
                extras[i].enabled = true;
            }
            else
            {
                extras[i].enabled = false;

            }
        }

        
    }

    public void MasExtra()
    {
        extraActual++;

        if (extraActual == 3)
        {
            final.SetActive(true);
        }
    }

}
