using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player; 
    float playerDistance;

    [Header("Confirguração da movimentação")]
    [SerializeField]
    float followRange; // Indica a que distancia deve ficar do player

    [SerializeField]
    float maxSpeed; // Velocidade maxima do inimigo

    [SerializeField]
    float acceleration; // Aceleração do inimigo

    [SerializeField]
    float slowdown;  // Desaceleração do inimigo

    [SerializeField]
    float rotateSpeed; // Velocidade de rotação
    float speed = 0; // Velocidade atual

    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player"); // Pega as informações do player
        

        
    }

    protected void Follow() // Esse método faz o inimigo andar na direção do player
    {

        // Movimento de proximação
        playerDistance = Vector2.Distance(player.transform.position, transform.position); // olha a distancia do player
        
        if(playerDistance > followRange){  // Pega o input de aceleração
            if(speed < maxSpeed){     
                speed += acceleration * Time.deltaTime;  // Aumenta a velocidade
            }    
        }
        else{
            if(speed > 0){
                speed -= slowdown * Time.deltaTime;  // Diminui a velocidade quando larga o acelerador 
            }
        }

        transform.Translate(Vector2.up * Time.deltaTime * speed); // faz a movimentação acontecer
        
        // Movimento de rotação
        Vector2 direction = player.transform.position - transform.position; // Pega a posição do inimigo e player
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f; // Mede o ângulo entre o inimigo e o player
        
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward); // Transforma o ângulo em um quaternion
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotateSpeed); // Aplica a rotação ...
        // ... de forma interpolada

    }


}
