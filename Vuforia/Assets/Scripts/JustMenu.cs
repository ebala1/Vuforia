using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JustMenu : MonoBehaviour {

	// Use this for initialization
	public void BackToMenu () {
        SceneManager.LoadScene("Scenes/UI");
    }

}
