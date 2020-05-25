using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_SelectPlayer : MonoBehaviour
{

   public int Player;
   public GameObject img;
   public GameObject img2;


   void Start()
   {
      if(PlayerPrefs.GetInt("currentPlayer") == Player)
         img.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
      else
      {
         img.GetComponent<Image>().color = new Color(0, 0, 0);
      }

   }
   public void Select()
   {
        PlayerPrefs.SetInt("currentPlayer", Player);
        img.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
        img2.GetComponent<Image>().color = new Color(0, 0, 0);
   }
}
