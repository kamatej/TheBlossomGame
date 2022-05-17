using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> ObjectsToSpawn = new List<GameObject>();
    public bool isTimer;
    public float timeToSpawn;
    private float currentTimeToSpawn;
    public bool isRandomized;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(isTimer)
        {
            UpdateTimer();
        }
    }

    private void UpdateTimer()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }

    public void SpawnObject()
    {
        int index = isRandomized ? Random.Range(0, ObjectsToSpawn.Count) : 0;

        if (ObjectsToSpawn.Count > 1)
        {
            Instantiate(ObjectsToSpawn[index], transform.position, transform.rotation);
        }
    }
}

