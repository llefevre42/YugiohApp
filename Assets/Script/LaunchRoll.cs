using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchRoll : MonoBehaviour
{
    public void roll()
    {
        GameObject rolling = GameObject.Find("Dice");
        DiceRoll Dice = rolling.GetComponent<DiceRoll>();
        
        if(Dice.Roll == 0)
            Dice.Roll = 1;
        else
            Dice.Roll = 0;
    }

}
