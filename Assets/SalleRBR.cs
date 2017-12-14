using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalleRBR : MonoBehaviour {

	GameObject [] vaches;
	GameObject Player;
	Transform PlayerT;
	bool PlayerOn = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		vaches = GameObject.FindGameObjectsWithTag ("vache");
	}

	void OnTriggerEnter(Collider c){
		// On vérifie si le player est bien dans la salle
		// Si oui alors les vaches le suive et l'attaque.
		Player = GameObject.FindGameObjectWithTag ("Player");
		PlayerOn = true;
		transform.LookAt (PlayerT);
		if (PlayerOn == true) {
			foreach(GameObject vache in vaches){
				//vache.transform.Translate(Vector3.up, 
				//vache.transform.position += transform.forward  * Time.deltaTime * 2;
				Debug.Log (vache);
			}
		}
	}
	void OnTriggerExit(Collider c){
		PlayerOn = false;
		Debug.Log (PlayerOn);
	}
}
