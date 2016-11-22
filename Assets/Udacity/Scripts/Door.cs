using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 

	private bool locked = true;
	private Animator anim;
    private GameObject signPost;
    private GvrAudioSource gvrAudio;

    public AudioClip lockedDoorSound;
    public AudioClip unlockedDoorSound;
    public float audioVolume = 0.7f;

	void Awake () {
        gvrAudio = GetComponent<GvrAudioSource>();
		anim = GetComponent<Animator> ();
        signPost = GameObject.FindGameObjectWithTag("SignPost");
        signPost.SetActive(false);
    }

    void Update() {
        // If the door is unlocked and it is not fully raised
        // Animate the door raising up
        // Play unlocked door sound
        if (locked == false)
        {
            anim.SetBool("unlocked", true);
            gvrAudio.PlayOneShot(unlockedDoorSound, audioVolume);
            signPost.SetActive(true);
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to true here
		locked = false;
    }

    public void ClickedLockedDoor ()
    {
        if (locked != false)
        {
            gvrAudio.PlayOneShot(lockedDoorSound, audioVolume);
        }
    }
}
