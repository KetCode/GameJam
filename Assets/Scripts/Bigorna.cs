using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigorna : MonoBehaviour
{
    
    float speed = 4;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        if (transform.position.y <= -5) Destroy(gameObject);
    }
}
