using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class B_CalculMenu : MonoBehaviour
{
    public int player;
    public Text hp;
    public void selectPlayer()
    {
        PlayerPrefs.SetInt("Player", player);
     //   PlayerPrefs.SetInt("hp" + PlayerPrefs.GetInt("Player") , int.Parse(hp.text));
        SceneManager.LoadScene("CalculMenu");
    }
}
