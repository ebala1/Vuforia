using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    // Use this for initialization
   public void Start()
    {
        SceneManager.LoadScene("Scenes/UI");
    }

}
