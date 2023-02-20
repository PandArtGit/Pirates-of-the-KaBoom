using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IDamageable))]
public class LifeController : MonoBehaviour
{
    IDamageable damageable;

    [SerializeField] Animator animatorController;
    [SerializeField] float life;
    [SerializeField] float maxLife;

    float damage;
    public float Life => life; // permite que a vida seja acessada pela UI
    public float MaxLife => maxLife;

    void Start()
    {
        damageable = GetComponent<IDamageable>();
        damageable.DamageEvent += OnDamage; // entrar no evento
    }

    void OnDestroy() // ao o objeto ser destruido
    {
        if(damageable != null){
            damageable.DamageEvent -= OnDamage; // sair do evento
        }    
    }
    void OnDamage(float damage) // metodo de ações a serem tomadas quando tomar dano
    {
        life -= damage; // diminuir a vida de acordo com o dano passado
        if(animatorController != null) //se o objeto tiver animação
            animatorController.SetFloat("Life", life); // diminuir a vida na animação
    }

    void DestroyMe() // metodo pra destruir o objeto pela animação
    {
        Destroy(gameObject); 
    }
}
