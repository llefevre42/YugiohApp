using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_SelectImage : MonoBehaviour
{
    public string Name;
    public void Select()
    {
        PlayerPrefs.SetString("PP" + PlayerPrefs.GetInt("currentPlayer").ToString(), Name);
        SceneManager.LoadScene("MainScreen");
    }
}
