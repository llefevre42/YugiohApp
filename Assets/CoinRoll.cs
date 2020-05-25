using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinRoll : MonoBehaviour
{
    public Image img;
    Sprite sprite1;
    public int Roll = 0;
    float launchTime;
    float currentTime;
    bool Up;
    bool Down;
    string Name;

    void Start()
    {
        sprite1 = Resources.Load<Sprite>("pile");
        img.sprite = sprite1;
    }

    public void roll()
    {
        if (Up == false && Down == false)
        {
            Up = true;
            launchTime = 0;
            currentTime = 0;
        }
    }
    void Update()
    {
        if (Up == true && currentTime > launchTime + 0.5f)
        {
            Up = false;
            Down = true;
        }
        else if (Down == true && currentTime > launchTime + 1)
        {
            Down = false;
        }

        currentTime += Time.deltaTime;

        if (Up == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 100);
        }
        else if (Down == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 100);
        }

        if (Up == true || Down == true)
        {
            if(Random.Range(0, 2) == 0)
                Name = "face";
            else
            {
                Name = "pile";
            }
            sprite1 = Resources.Load<Sprite>(Name);
            img.sprite = sprite1;
        }
    }
}
