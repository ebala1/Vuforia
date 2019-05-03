using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoseAnim : MonoBehaviour {
    private Animator Anim;
	
	void Start () {
        Anim = GetComponent<Animator>();
        Anim.speed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AnimUp()
    {
        Anim.Play("RoseSee", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimRotate()
    {
        Anim.Play("RoseRotate", -1, 0f);
        Anim.speed = 1f;
    }
}
