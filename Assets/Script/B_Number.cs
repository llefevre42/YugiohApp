using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class B_Number : MonoBehaviour
{
    public Text amount;
    public int value;
    int amount2;
    public void add()
    {
        amount2 = int.Parse(amount.text);
        amount2 *= 10;
        amount2 += value;
        if(value > 90000)
            value = 90000;
        amount.text = amount2.ToString();
    }
}
