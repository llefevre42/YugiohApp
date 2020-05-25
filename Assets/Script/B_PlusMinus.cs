using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class B_PlusMinus : MonoBehaviour
{
    public int PosiNega;
    public void PlusMinus()
    {
        PlayerPrefs.SetInt("PosiNega", PosiNega);
        SceneManager.LoadScene("Calcul");
    }
}
