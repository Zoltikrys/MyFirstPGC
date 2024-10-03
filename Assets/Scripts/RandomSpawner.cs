using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefab; //this is the object to respawn
    public int spawnCount = 10; // will spawn this many times

    

    // Start is called before the first frame update
    void Start()
    {

        //DateTime now = DateTime.Now;
        //string dt_str = DateTime.Now.ToString("yyyy-MM-dd");

        //int customSeed = Int32.Parse(dt_str);


        


        //int customSeed = UnityEngine.Random.Range(0, 999);
        //UnityEngine.Random.InitState(customSeed);

        for (int i = 0; i < spawnCount; i++)
        {
            // Generate random positions within a certain range to spawn the game object in
            Vector3 randomPosition = new Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(1, 10), UnityEngine.Random.Range(-10, 10));
            Instantiate(prefab, randomPosition, Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
