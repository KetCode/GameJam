using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    Jogador jogador;
    Spawn spawn;

    void Start()
    {
        jogador = FindObjectOfType<Jogador>();
        spawn = FindObjectOfType<Spawn>();
    }

    void Update()
    {
        if (Physics2D.OverlapBoxAll(jogador.transform.position, Vector2.one * 0.3f, 0, LayerMask.GetMask("Inimigo")).Length > 0) {
            // colisão
            Debug.Break();
        }
    }
}
