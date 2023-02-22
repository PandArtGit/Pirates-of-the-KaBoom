using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : Enemy
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject cannon;
    [SerializeField] float fireRate;
    float timeToFire;

    void Update()
    {
        if(player != null){ // Se o player existir, seguir com os métodos
            Follow();
            Attack();
        }
        
    }

    void Attack()
    {
        if (playerDistance < followRange && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / fireRate; //Evitar spamar projetil
        
            Instantiate(projectile, cannon.transform.position, cannon.transform.rotation);
            //instanciar Bala, a partir do PIVOT, mantendo o ângulo
        }
    }
}
