using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    public GameObject frog;
    public GameObject gema;
    public float timeBetweenSpawn;
    private float spawnTime;

    private int chances;

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > spawnTime)
        {
            chances = Random.Range(0,5);

            if (chances == 1){
                Spawn(gema);
            } else {
                Spawn(frog);
            }

            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn(GameObject gameObject) 
    {
        Instantiate(gameObject, transform.position + new Vector3(3.84f, 0.44f, 0f), transform.rotation);
    }
}
