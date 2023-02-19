using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IDamageable))]
public class LifeController : MonoBehaviour
{
    IDamageable damageable;

    [SerializeField] float life;
    [SerializeField] float maxLife;

    public float Life => life;
    public float MaxLife => maxLife;

    void Start()
    {
        damageable = GetComponent<IDamageable>();
        damageable.DamageEvent += OnDamage;
    }
    void Update()
    {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        if(damageable != null){
            damageable.DamageEvent -= OnDamage;
        }    
    }
    void OnDamage()
    {
        life--;
    }
}
