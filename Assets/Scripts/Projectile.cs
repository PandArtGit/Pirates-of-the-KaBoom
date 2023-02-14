using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    float speed = 5;
    void Start()
    {
       Destroy(gameObject, 1);
    }
    
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
