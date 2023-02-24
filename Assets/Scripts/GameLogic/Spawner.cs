using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   

    [SerializeField] GameOverMenu gameOverMenu;
    [SerializeField] GameObject[] spawner = new GameObject[4];
    [SerializeField] GameObject[] enemy = new GameObject[2];
    float gameEnd;
    float spawnRate;
    

    int[] randomEnemy = new int[4];
    float time;
    void Start() {

        


        // -------------- DATA LOADING ------------------
        gameEnd = PlayerPrefs.GetFloat("GameEnd");
        spawnRate = PlayerPrefs.GetFloat("SpawnRate");
        //-----------------------------------------------
        


        // --------------- SPAWNER LOOP -----------------
        time = gameEnd * 60;
        StartCoroutine(SpawnEnemy());
        // ----------------------------------------------


    }
    void Update() {

        time -= Time.deltaTime; // faz o cronometro andar
        
        // ---------- RANDOMIZADOR DE INIMIGOS --------
        for (int i = 0; i < 4; i++)
            {
                randomEnemy[i] = Random.Range(0,2);
            }
        // --------------------------------------------
    }



    IEnumerator SpawnEnemy(){
        
        while(time > 5 && GameObject.Find("Player") != null){
            print(GameObject.Find("Player"));
            print("Vou Spawnar: " + time);
            EnemyInstantiate();
            yield return new WaitForSeconds(spawnRate);
            
        }
        if(GameObject.Find("Player"))
        {
            print(GameObject.Find("Player"));
            WinTrigger();
        }
    }
    void EnemyInstantiate()
    {
        for (int i = 0; i < 4; i++)
            {
                
                Instantiate(enemy[randomEnemy[i]], spawner[i].transform.position,Quaternion.identity);
            }
    }
    void WinTrigger(){

        print("Ganhei");
        gameOverMenu.GameOver("Win");
        
    }

}
