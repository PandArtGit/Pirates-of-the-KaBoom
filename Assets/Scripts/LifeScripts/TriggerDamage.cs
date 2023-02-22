using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDamage : MonoBehaviour
{
    [SerializeField] protected float damage; // Dano a ser passado
    [SerializeField] GameObject prefrab;
    [SerializeField] bool ImBullet;
    Animator animator;
    void Start()
    {
        if(!ImBullet){
            animator = GetComponent<Animator>();
        }
        
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        IDamageable damageable = other.GetComponent<IDamageable>();
        if(damageable != null){ // se o objeto puder ser machucado

            if(!ImBullet && other.tag == "Player"){  // Se for o Chaser vai se explodir
                ChaserEffect(damageable);
            }

            if(ImBullet){    // se for a bala vai passar o dano e o efeito
                BulletEffect(damageable);
            }
            
        }
    }
    void BulletEffect(IDamageable damageable)
    {
        
        Instantiate(prefrab, transform.position, Quaternion.identity);
        damageable.TakeDamage(damage);
        Destroy(gameObject);
    }

    void ChaserEffect(IDamageable damageable)
    {
        animator.SetTrigger("HitPlayer");
        damageable.TakeDamage(damage);
        
    }


}
