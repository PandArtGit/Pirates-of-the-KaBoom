using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    [Header("Confirguração da movimentação")]
    [SerializeField] float maxSpeed; // Velocidade maxima do barco  
    [SerializeField] float acceleration; // Aceleração do barco
    [SerializeField] float slowdown; // Desaceleração do barco
    
    float speed = 0; // Velocidade atual do barco

    [SerializeField] float rotateSpeed; // Velocidade de rotação do barco

    float rotateAxis; // Eixo de rotação do barco
   
    void Update()
    {
        // Não deixa sair do mapa
        limitMoviment(8, -8);
        // Mover pra frente
        if(Input.GetKey(KeyCode.UpArrow)){  // Pega o input de aceleração
            if(speed < maxSpeed){     
                speed += acceleration * Time.deltaTime;  // aumenta a velocidade
            }    
        }
        else{
            if(speed > 0){
                speed -= slowdown * Time.deltaTime;  // diminui a velocidade quando larga o acelerador 
            }
        }

        transform.Translate(Vector3.up * Time.deltaTime * speed); // faz a movimentação do barco
        

        // Rotacionar
        rotateAxis = Input.GetAxis("Horizontal")  * -1; // Pega o input de rotação com a polaridade invertida
                        //(A = Positivo | D = Negativo)

        transform.Rotate(Vector3.forward * rotateAxis * Time.deltaTime * rotateSpeed); // faz a rotação do barco
    }

    void limitMoviment(float limitA, float limitB)
    {
        if(transform.position.x > limitA)
        {
            transform.Translate(Vector2.right * -maxSpeed * Time.deltaTime, Space.World);
        }
        if(transform.position.x < limitB)
        {
            transform.Translate(Vector2.right * maxSpeed * Time.deltaTime, Space.World);
        }
    }

}
