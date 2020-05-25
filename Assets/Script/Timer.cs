using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeLeft;
    public Text value;
    public Text hp1;
    public Text hp2;
    public GameObject img;
    public int vari;


    void Start()
    {
        timeLeft = PlayerPrefs.GetFloat("time");
        if(PlayerPrefs.GetInt("paused") == 1)
            img.GetComponent<Image>().color = new Color(255, 178, 0);
    }
     
    void Update()
    {
        int min = Mathf.FloorToInt(timeLeft / 60);
        int sec = Mathf.FloorToInt(timeLeft % 60);
        
        value.text = min.ToString("00") + ":" + sec.ToString("00");
        if (PlayerPrefs.GetInt("paused") == 0)
            timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            PlayerPrefs.SetInt("paused", 1);
            timeLeft = 0;
            img.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if(PlayerPrefs.GetInt("currenthp1") > PlayerPrefs.GetInt("hp1"))
        {
            if (PlayerPrefs.GetInt("currenthp1") > PlayerPrefs.GetInt("hp1") + vari)
                PlayerPrefs.SetInt("currenthp1", PlayerPrefs.GetInt("currenthp1") - vari);
            else
                PlayerPrefs.SetInt("currenthp1", PlayerPrefs.GetInt("hp1"));
        }
        else
        {
            if (PlayerPrefs.GetInt("currenthp1") < PlayerPrefs.GetInt("hp1") - vari)
                PlayerPrefs.SetInt("currenthp1", PlayerPrefs.GetInt("currenthp1") + vari);
            else
                PlayerPrefs.SetInt("currenthp1", PlayerPrefs.GetInt("hp1"));
        }
        hp1.text = PlayerPrefs.GetInt("currenthp1").ToString();

        if (PlayerPrefs.GetInt("currenthp2") > PlayerPrefs.GetInt("hp2"))
        {
            if (PlayerPrefs.GetInt("currenthp2") > PlayerPrefs.GetInt("hp2") + vari)
                PlayerPrefs.SetInt("currenthp2", PlayerPrefs.GetInt("currenthp2") - vari);
            else
                PlayerPrefs.SetInt("currenthp2", PlayerPrefs.GetInt("hp2"));
        }
        else
        {
            if (PlayerPrefs.GetInt("currenthp2") < PlayerPrefs.GetInt("hp2") - vari)
                PlayerPrefs.SetInt("currenthp2", PlayerPrefs.GetInt("currenthp2") + vari);
            else
                PlayerPrefs.SetInt("currenthp2", PlayerPrefs.GetInt("hp2"));
        }
        hp2.text = PlayerPrefs.GetInt("currenthp2").ToString();


    }
    public void passedTime()
    {
        PlayerPrefs.SetFloat("time", (int)timeLeft);
    }
    
    public void paused()
    {
        if(PlayerPrefs.GetInt("paused") == 0)
        {
            PlayerPrefs.SetInt("paused", 1);
            img.GetComponent<Image>().color = new Color(255, 178, 0);
        }
        else if(PlayerPrefs.GetInt("paused") == 1)
        {
            PlayerPrefs.SetInt("paused", 0);
            img.GetComponent<Image>().color = new Color(0, 0, 0);
        }
    }
}
