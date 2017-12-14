using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneMort : MonoBehaviour {

	public Player player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider c){
		player.vie = 0;
		Debug.Log ("zoneMort");
	}
}
