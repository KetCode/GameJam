using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    CharacterController controller;
    
    // movimentação
    Vector2 x;
    float xspeed = 5;
    
    // pulo
    Vector2 y;
    float maxHeight = 2f; // altura maxima
    float timeToPeak = 0.3f; // tempo de pulo
    float jumpSpeed;

    // fisica
    Vector2 finalVelocity;
    float gravity;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        gravity = (2 * maxHeight) / Mathf.Pow(timeToPeak, 2); // calcula a gravidade

        jumpSpeed = gravity * timeToPeak; // calcula a velocidade
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        x = xspeed * xInput * Vector2.right; 

        y += gravity * Time.deltaTime * Vector2.down; // somando a gravidade ao vetor
        if (controller.isGrounded) y = Vector2.down;
        if (Input.GetKeyDown(KeyCode.UpArrow) && controller.isGrounded) y = jumpSpeed * Vector2.up;

        finalVelocity = x + y;
        controller.Move(finalVelocity * Time.deltaTime);
    }
}