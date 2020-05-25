using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfilPick : MonoBehaviour
{
    Sprite sprite1;

    public string number;
    public Image img;
    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("PP" + number));
        if(PlayerPrefs.GetString("PP" + number) != "")
            sprite1 = Resources.Load<Sprite>(PlayerPrefs.GetString("PP" + number));
        else
        {
            sprite1 = Resources.Load<Sprite>("dino");
        }
        img.sprite = sprite1;
    }

}
