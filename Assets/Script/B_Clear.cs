using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class B_Clear : MonoBehaviour
{
    public Text amount;
    public void clear()
    {
        amount.text = 0.ToString();
    }
}
