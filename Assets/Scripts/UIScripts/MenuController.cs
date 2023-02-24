using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    float gameEndSlider;
    float spawnRateSlider;
    float gameEnd;
    float spawnRate;
    static Animator animator;
    void Start()
    {
        // -------------- DATA LOADING ------------------
        gameEnd = PlayerPrefs.GetFloat("GameEnd");
        spawnRate = PlayerPrefs.GetFloat("SpawnRate");
        //-----------------------------------------------
        
        
        animator = GetComponent<Animator>();    
    }

    public void ConfigButton()
    {
        animator.Play("ConfigMenu");
    }

    public void ReturnButton()
    {
        animator.Play("ReturnMenu");
        // -------------- DATA SAVE ------------------
        PlayerPrefs.SetFloat("GameEnd", gameEnd);
        PlayerPrefs.SetFloat("SpawnRate", spawnRate);
        //-----------------------------------------------
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(2);
    }

    public void SetGameEnd()
    {   gameEndSlider = GameObject.Find ("GameEndSlider").GetComponent<Slider>().value;
        gameEnd = gameEndSlider;
    }
    public void SetSpawnRate()
    {   
        spawnRateSlider = GameObject.Find ("SpawnRateSlider").GetComponent<Slider>().value;
        spawnRate = 30 - spawnRateSlider * 5;
    }
}
