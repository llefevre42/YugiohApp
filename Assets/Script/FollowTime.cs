using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTime : MonoBehaviour
{
    float timeLeft;

    void Start()
    {
        timeLeft = PlayerPrefs.GetFloat("time");
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("paused") == 0)
            timeLeft += Time.deltaTime;
    }

    public void passedTime()
    {
        PlayerPrefs.SetFloat("time", (int)timeLeft);
    }
}
