using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeCollider : MonoBehaviour
{

    public float despawntimer = 3;

    public Timer_Score ScoreScript;

    //public GameObject ScoreObject;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Score = GameObject.Find("Timer&ScoreScipt");
        ScoreScript = Score.GetComponent<Timer_Score>();

    }

    // Update is called once per frame
    void Update()
    {

        despawntimer -= Time.deltaTime;

        if (despawntimer < 0)
        {
            Destroy(this.gameObject);
        }


    }

   void OnTriggerEnter(Collider other)
    {

        if(this.tag == "BeeBomb" && other.tag == "Player")
        {
            print("lost"); //condition of losing 
            Destroy(this.gameObject);
           // GameObject Explode = GameObject.Find("Explossion");
           // ScoreScript = Score.GetComponent<Timer_Score>();
        }


        if (this.tag == "Bee" && other.tag == "Player")
        {
            print("add point");
            ScoreScript.Score += 1f;
            Destroy(this.gameObject);
        }

    }

}
