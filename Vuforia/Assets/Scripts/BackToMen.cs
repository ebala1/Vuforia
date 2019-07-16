using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMen : MonoBehaviour
{

    // Use this for initialization
    public void GoToMen()
    {
        SceneManager.LoadScene("Scenes/UI");
    }

    public void DontGoToMen()
    {
        SceneManager.LoadScene("Scenes/LoveCologne");
    }

}
