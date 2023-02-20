using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDamage : MonoBehaviour
{
    [SerializeField] Animator animator; 
    [SerializeField] float damage; // Dano a ser passado
    [SerializeField] GameObject explosion; // efeito de explosão

    void OnTriggerEnter2D(Collider2D other) {
        IDamageable damageable = other.GetComponent<IDamageable>();
        if(damageable != null){ // se o objeto puder ser machucado

            Instantiate(explosion, transform.position , Quaternion.identity); // instaciar efeito
            damageable.TakeDamage(damage); //passar o dano
            
            if(animator == null){ // se o objeto não tiver animação
                Destroy(gameObject); // destroir no mesmo momento
            }
            else{
                animator.SetFloat("Life", 0); // se tiver animação, iniciar animação final
            }
            

             
        }
    }
}
