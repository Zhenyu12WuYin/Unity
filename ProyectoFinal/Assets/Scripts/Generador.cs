using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float spawnRate;
    public Vector2 spawnAreaMin = new Vector2(-5f, -6f);
    public Vector2 spawnAreaMax = new Vector2(35f, -1f);
    private string dificultad;

    // Start is called before the first frame update
    void Start()
    {
        dificultad = PlayerPrefs.GetString("Dificultad");
        switch (dificultad)
        {
            case "Fácil":
                spawnRate = 5f;
                break;

            case "Medio":
                spawnRate = 3f;
                break;

            case "Difícil":
                spawnRate = 1.5f;
                break;
        }
        InvokeRepeating("SpawnEnemy", 0f, spawnRate);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        int randomX = (int)Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        int randomY = (int)Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);


        GameObject Instancia= Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        Destroy(Instancia,10f);
    }
}
