using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatTrigger : MonoBehaviour
{
    [SerializeField] GameOverMenu gameOverMenu;
    void OnDestroy() {
        print("perdi");
        gameOverMenu.GameOver("Defeat");    
    }
}
