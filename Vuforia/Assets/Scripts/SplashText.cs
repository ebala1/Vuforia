using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SplashText: MonoBehaviour
{
   
    public Text splashText;
    

    IEnumerator Start()
    {
       
        splashText.canvasRenderer.SetAlpha(0.0f);
        FadeIn();
        yield return new WaitForSeconds(4.5f);
        FadeOut();
        yield return new WaitForSeconds(4.5f);
       
    }

    void FadeIn()
    {
        
        splashText.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        
        splashText.CrossFadeAlpha(0.0f, 2.5f, false);
    }
}

