using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMap : MonoBehaviour
{

    // Use this for initialization
    public void GoToMap()
    {
        SceneManager.LoadScene("Scenes/new");
    }
}
