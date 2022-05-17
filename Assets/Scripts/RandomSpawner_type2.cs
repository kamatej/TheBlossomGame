using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner_type2 : MonoBehaviour
{

    public Transform[] BeeSpawnlocations;
    public Transform[] BeeBombSpawnlocations;
    public int RandomLocationNumbers;    //control spawn point

    public GameObject Bee;
    public GameObject BeeBomb;    //prefab to spawn

    public float SpawnTimer1;  
    public float SpawnTimer2;   //different timer for 2 bees


    public bool spawn1;
    public bool spawn2;     //2 bool control

    void Update()
    {
        SpawnTimer1 -= Time.deltaTime;
        SpawnTimer2 -= Time.deltaTime;     //timer count down  +- timer from 0 counting up

        if (SpawnTimer1 < 0) //Bee spawner, if it reach 0, does following action
        {
            spawn1 = !spawn1;
            if (!spawn1)               // if the bool is true, its false ----- if its true, its false , moment of bool switch between T and F
            {
                RandomLocationNumbers = Random.Range(0, 4);
                BeeSpawnlocations[RandomLocationNumbers].rotation = Quaternion.Euler(new Vector3(-90, 0, Random.Range(0, 360)));
                var rotation = BeeSpawnlocations[RandomLocationNumbers].rotation;

                Instantiate(Bee, BeeSpawnlocations[RandomLocationNumbers].position, rotation);
                SpawnTimer1 = 4;
            }         
        }

        if (SpawnTimer2 < -2) //Bee spawner
        {
            spawn2 = !spawn2;
            if (!spawn2)
            {
                RandomLocationNumbers = Random.Range(0, 2);
                BeeSpawnlocations[RandomLocationNumbers].rotation = Quaternion.Euler(new Vector3(-90, 0, Random.Range(0, 360)));
                var rotation = BeeSpawnlocations[RandomLocationNumbers].rotation;

                Instantiate(BeeBomb, BeeBombSpawnlocations[RandomLocationNumbers].position, rotation);
                SpawnTimer2 = 3;
            }      
        }
    }



}
