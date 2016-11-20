using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 

	private bool locked;
	private Animator anim;

	void Awake () {
		anim = GetComponent<Animator> ();
	}

    void Update() {
        // If the door is unlocked and it is not fully raised
		// Animate the door raising up
		if (locked == false)
			anim.SetBool ("unlocked", true);
    }

    public void Unlock()
    {
        // You'll need to set "locked" to true here
		locked = false;
    }
}
