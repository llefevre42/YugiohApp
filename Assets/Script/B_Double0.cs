using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_Double0 : MonoBehaviour
{
    public Text amount;
    int amount2;
    public void add()
    {
        amount2 = int.Parse(amount.text);
        amount2 *= 100;
        amount.text = amount2.ToString();
    }
}
