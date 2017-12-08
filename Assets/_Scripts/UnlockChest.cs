using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UnlockChest : MonoBehaviour {
	// Tag of the object that unlock the chest
	private String objectTagToUnlock = "Key";

	void Start () {
		
	}

	void OnTriggerEnter(Collider other){
		Debug.Log("TRIGGERED");
		GameObject collidedObject = other.gameObject;
		if(collidedObject.tag.Equals(objectTagToUnlock)){
			Destroy(collidedObject);
			// lancer l'ouverture du coffre
			// éventuellement une petite musique fort sympathique
		}
	}
}
