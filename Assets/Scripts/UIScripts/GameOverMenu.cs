using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    protected bool isOver = false;
    string scoreTxt;
    protected Animator animator;
    [SerializeField] TextMeshProUGUI scoreTxtUi;

    void Start() {
        animator = GetComponent<Animator>();    
    }

    public static void PlayButton()
    {
        SceneManager.LoadScene(2);
    }
    public static void MenuButton()
    {
        SceneManager.LoadScene(1);
    }

    public void GameOver(string result)
    {
        if(PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", PlayerPrefs.GetInt("Score"));
            scoreTxt = "NOVO RECORD: " + PlayerPrefs.GetInt("Score");
        }
        else{
            scoreTxt = "Score: " + PlayerPrefs.GetInt("Score");
        }

        scoreTxtUi.text = scoreTxt;

        if(!isOver){
            animator.Play(result);
            isOver = true;
        }
        
    }
}
