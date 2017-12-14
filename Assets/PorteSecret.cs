using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteSecret : MonoBehaviour {
	
	public GameObject Porte;
	public float timerDoor;
	public bool doorOpen = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () { 
		
		GameObject[] Gob;	
		// Calcul le nombre de gobelin dans la salle
		Gob = GameObject.FindGameObjectsWithTag ("Gobelin");
		// Si il y a plus de gobelin dans la salle alors la porte s'ouvre
		if(Gob.Length == 0){
			if (doorOpen == false) {
				timerDoor += Time.deltaTime;
				doorOpen = true;
				if (timerDoor < 5) {
					transform.Translate (Vector3.right * Time.deltaTime * 200, Space.World);
				} else {
					timerDoor = 0;
					doorOpen = false;
				}
			}

		}
	
	}
}
