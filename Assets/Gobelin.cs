using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gobelin : MonoBehaviour {

	public int vie, degat;
	public Player playerP;
	public Transform playerT;
	public GameObject gobelin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (playerT);
		if(vie == 0 || vie < 0){
			Debug.Log ("Beng t'es mort");
			Destroy(gobelin);
		}
	}

	void OnTriggerEnter(Collider c){
		vie = vie - playerP.degat;
		Debug.Log (vie);
	}
}
