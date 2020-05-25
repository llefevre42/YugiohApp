using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_Add : MonoBehaviour
{
    public int b1 = 0;
    public Text value = null;
    public void adition()
    {
        b1++;
        value.text = b1.ToString();
    }
}
