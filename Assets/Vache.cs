using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vache : MonoBehaviour {

	public int vie, degat;
	public Transform player;
	public Player playerP;
	public GameObject vache;


	void Start () {
		
	}

	void Update () {
		player = GameObject.FindWithTag ("Player").transform;
		transform.LookAt (player);
		if (vie == 0 || vie < 0) {
			Debug.Log ("Beng t'es mort");
			Destroy (vache);

		}

	}

	void OnTriggerEnter(Collider c){
		vie = vie - playerP.degat;
		Debug.Log (vie);
	}
}
