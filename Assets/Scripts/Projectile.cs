using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 5; // Velocidade do projetil 
    void Start()
    {
       Destroy(gameObject, 1); // depois de iniciar, vai se destruir em 1 segundo
    }
    
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed); // vai fazer ele se mover
    }
}
