using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartPlayerPrefs : MonoBehaviour
{
  
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("Record", 0);
        PlayerPrefs.SetFloat("SpawnRate", 20);
        PlayerPrefs.SetFloat("GameEnd", 2);

        SceneManager.LoadScene(1);
    }
}
