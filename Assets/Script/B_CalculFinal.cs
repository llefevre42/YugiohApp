using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class B_CalculFinal : MonoBehaviour
{
    public Text amount;
    int result;
    public void Calcul()
    {
        result = PlayerPrefs.GetInt("hp" + PlayerPrefs.GetInt("Player")) + (int.Parse(amount.text) * PlayerPrefs.GetInt("PosiNega"));
        if(result > 99999)
            result = 99999;
        if(result < 0)
            result = 0;
        PlayerPrefs.SetInt("hp" + PlayerPrefs.GetInt("Player"), result);
        SceneManager.LoadScene("MainScreen");
    }
}
