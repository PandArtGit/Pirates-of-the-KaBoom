using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : Enemy
{   
    void Update()
    {
        if(player != null){ // Se o player existir, seguir com os métodos
            Follow();
        }
        
    }
}
