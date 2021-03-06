﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public Door door;

	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Destroy the key. Check the Unity documentation on how to use Destroy

		Instantiate (keyPoofPrefab, new Vector3 (-6.45f, 12.01f, 42.11f), Quaternion.Euler(-90f, 0, 0));
		door.Unlock ();
		Destroy (gameObject);
    }

    public void KeyAnimation ()
    {
        Animator keyAnim = GetComponent<Animator>();

        keyAnim.SetBool("detected key", true);
    }
}
