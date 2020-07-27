using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_Reset : MonoBehaviour
{
    public void Reset()
    {
        PlayerPrefs.SetInt("hp1", 8000);
        PlayerPrefs.SetInt("hp2", 8000);
        PlayerPrefs.SetInt("currenthp1", 8000);
        PlayerPrefs.SetInt("currenthp2", 8000);
        SceneManager.LoadScene("MainScreen");
   }
    public void ResetTime()
    {
        PlayerPrefs.SetFloat("time", 0);
        PlayerPrefs.SetInt("paused", 1);
        SceneManager.LoadScene("MainScreen");
   }

   public void ChangeAvatar()
   {
        SceneManager.LoadScene("ChangeAvatar");
   }
}
