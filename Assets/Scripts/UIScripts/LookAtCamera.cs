using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    void LateUpdate() {
        Vector3 target = transform.position + Camera.main.transform.forward;
        transform.LookAt(target, Camera.main.transform.up);
    }
}
