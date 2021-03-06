﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoofPrefab;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

		Instantiate (coinPoofPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler (-90f, 0, 0));
		Destroy (gameObject);
    }
}
