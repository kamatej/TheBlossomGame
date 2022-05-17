using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

///////////////--------------   random spawn list

    public List<GameObject> BeeTypes = new List<GameObject>();
    public List<int> setNumbers = new List<int>();

    [Range(0, 10)]
    public float range = 10;  //max and min range position in world
///////////////--------------

    public Transform spawnposition;

    // Start is called before the first frame update
    void Start()
    {
        SetUpBees(range);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUpBees(float range)
    {
       for (int i = 0; i < setNumbers.Count; i++) //check how many types of bees are there

                for (int j = 0; j < setNumbers[i]; j++) //spawn a type of bees with set numbers
            {
                var position = new Vector3(Random.Range(-range, range), 0, Random.Range(-range, range));
                Instantiate(BeeTypes[i], position, Quaternion.identity);
            }
    }

}
