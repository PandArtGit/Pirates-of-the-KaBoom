using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    void DestroyMe(){
        Destroy(gameObject);
    }
}
