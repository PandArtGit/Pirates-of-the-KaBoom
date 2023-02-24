using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimationControllerParamenters
{
    public const string LifePercent = "LifePercent";
    public const string IsDead = "IsDead";
}

public class AnimationController : MonoBehaviour
{
    Animator animator;
    IDamageable damageable;
    [SerializeField] LifebarUI heath;

    void Awake() { // Quando o objeto acordar vai pegar os componentes
        damageable = GetComponent<IDamageable>();
        animator = GetComponent<Animator>();
    }

    void Start() {
        damageable.DamageEvent += OnDamage; // entra no evento
    }

    void OnDestroy(){
        if(damageable != null){
            damageable.DamageEvent -= OnDamage; // sai do evento
        }
    }

    private void Update() {
        if(heath.LifeToAnimation < 1){ // se a vida do objeto acabar, manda fazer a animação de morte
            animator.SetTrigger("IsDead");
        }
        
    }

    void OnDamage(float damage){
        animator.SetFloat(AnimationControllerParamenters.LifePercent, heath.LifePercent);
        // diminui a vida na animação
    }
}

