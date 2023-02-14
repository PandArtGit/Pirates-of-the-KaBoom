using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Canhões | 0 CF | 1 2 3 CR | 4 5 6 CL")]
    [SerializeField]
    GameObject[] cannons = new GameObject[7]; // Array pra guardar os canhões

    [SerializeField]
    GameObject projectile; // Prefab da bola de canhão


    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.Space)){   
            ShootSide(0, 0);                 // Chama o método que atira pra frente (Canhão 0)
        }
        if(Input.GetKeyDown(KeyCode.E)){
            ShootSide(1, 3);                // Chama o metodo que atira lateralmente (Canhões 1 - 3 | Direita )
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            ShootSide(4, 6);                // Chama o metodo que atira lateralmente (Canhões 4 - 6 | Esquerda )
        }
    }
    void ShootSide(int start, int end) // Método que instancia o prefab nos canhões indicados
    {   
        for (int i = start; i < end+1; i++)
        {
            Instantiate(projectile, cannons[i].transform.position, cannons[i].transform.rotation);
        }
        
    }
    
}
