using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Score : MonoBehaviour
{
    public Text Timer_Text;
    public float Timer;

    public Text Score_Text;
    public float Score;

    public string Gamestate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Gamestate == "Playable")
        {
            Timer += Time.deltaTime;

            Timer_Text.text = Timer.ToString("00");

            Score_Text.text = Score.ToString("0000");
        }


        if (Timer < 0)
        {
            Timer = 0;
        }
    }


    public void playbutton()
    {
        Gamestate = "Playable";
    }

}
