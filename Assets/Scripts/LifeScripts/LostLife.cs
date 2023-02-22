using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostLife : MonoBehaviour, IDamageable
{
    public event Action<float> DamageEvent;
    public void TakeDamage(float damage){
        DamageEvent.Invoke(damage);
        
    }
    
}
