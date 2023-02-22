using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] GameObject effect;
    [SerializeField] float lifeTime; // Tempo de duração na tela
    [SerializeField] float speed = 5; // Velocidade do projetil 
    void Start()
    {
       Destroy(gameObject, lifeTime); // depois de iniciar, vai se destruir em 1 segundo
    }

    void OnDestroy() {
            Instantiate(effect, transform.position, Quaternion.identity);
    }
    
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed); // vai fazer ele se mover
    }
}
