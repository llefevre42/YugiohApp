using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_Division : MonoBehaviour
{
    int div;
    public void division()
    {
        div = PlayerPrefs.GetInt("hp" + PlayerPrefs.GetInt("Player"));
        div /= 2;
        PlayerPrefs.SetInt("hp" + PlayerPrefs.GetInt("Player"),div);
        SceneManager.LoadScene("MainScreen");
    }
}
