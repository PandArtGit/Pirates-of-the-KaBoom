using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostLife : MonoBehaviour, IDamageable
{
    public event Action DamageEvent;
    public void TakeDamage(){
        DamageEvent.Invoke();
    }
    
}
