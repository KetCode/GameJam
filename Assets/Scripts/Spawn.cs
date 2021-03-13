using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{    
    struct SpawnTime {
        public float interval; // intervalo em segundos para aparecer
        public float instantiateTime; // tempo para instanciar
        public float variation; 
    }

    // public Sprite[] cactusSprites;

    public GameObject tiroPrefabRef;
    public GameObject bigornaPrefabRef;

    SpawnTime tiro;
    SpawnTime bigorna;

    public bool stopSpawn = false;

    void Start()
    {
        tiro.interval = 1;
        tiro.instantiateTime = 0;
        tiro.variation = 0.5f;

        bigorna.interval = 1;
        bigorna.instantiateTime = 0;
        bigorna.variation = 0.5f;
    }

    void Update()
    {
        // spawn tiro
        if (Time.time > tiro.instantiateTime && !stopSpawn) {
            // instancia o objeto
            GameObject obj = Instantiate(tiroPrefabRef, new Vector3(5, -3), Quaternion.identity); // posição dos tiros
            obj.AddComponent<BoxCollider2D>();
            tiro.instantiateTime = Time.time + Random.Range(tiro.interval - tiro.variation, tiro.interval + tiro.variation); // intervalo diferente
        }

        // spawn bigorna
        if (Time.time > bigorna.instantiateTime && !stopSpawn) {
            // instancia o objeto
            GameObject obj = Instantiate(bigornaPrefabRef, new Vector3(-8, 4.5f), Quaternion.identity); // posição da bigorna
            obj.AddComponent<BoxCollider2D>();
            bigorna.instantiateTime = Time.time + Random.Range(bigorna.interval - bigorna.variation, bigorna.interval + bigorna.variation); // intervalo diferente
        }
    }
}
