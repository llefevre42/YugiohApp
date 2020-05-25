using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class B_back : MonoBehaviour
{
    public string SceneName;

    public void backu()
    {
        SceneManager.LoadScene(SceneName);
    }
}
