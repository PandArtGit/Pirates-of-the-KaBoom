using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] spawner = new GameObject[4];
    [SerializeField] GameObject[] enemy = new GameObject[2];
    [SerializeField] float gameEnd;
    [SerializeField] float spawnRate;
    
    int[] randomEnemy = new int[4];
    float time;
    void Start() {
        time = gameEnd * 60;
        StartCoroutine(SpawnEnemy());
    }
    void Update() {
        time -= Time.deltaTime;
        print("Segundos até acabar: " + time);
        for (int i = 0; i < 4; i++)
            {
                randomEnemy[i] = Random.Range(0,2);
            }
    }



    IEnumerator SpawnEnemy(){
        while(time>0){
            yield return new WaitForSeconds(spawnRate);
            for (int i = 0; i < 4; i++)
            {
                
                Instantiate(enemy[randomEnemy[i]], spawner[i].transform.position,Quaternion.identity);
            }
        }
    }

}
