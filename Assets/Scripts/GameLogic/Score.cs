using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int record;
    void Start() {
        PlayerPrefs.SetInt("Score", 0);
        record = PlayerPrefs.GetInt("Record"); 
    }
}
