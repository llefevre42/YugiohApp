using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CalculUpdate : MonoBehaviour
{
    public Text calcul;
    public Text amount;
    private char add;
    void Update()
    {
        if(PlayerPrefs.GetInt("PosiNega") > 0)
        {
            add = '+';
        }
        else
        {
            add = '-';
        }
        calcul.text = PlayerPrefs.GetInt("hp" + PlayerPrefs.GetInt("Player")) + " " + add + " " + amount.text;
    }
}
