using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour {

	private float timer;
	public GameObject VachePrefab;
	public Transform VacheSpawn;

	// Use this for initialization
	void Start () {
		// Permet de lancer le script PopVache toutes les X secondes 2 fois
		InvokeRepeating ("PopVache", 30.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		// Permet de faire spawn un élément aléatoirement dans un circle de x porter
		transform.position = Random.insideUnitCircle * 5;
	}

	void PopVache(){
		// La vache dans présente dans la hierarchy est cloner.
		// On sort la vache primaire du champs de vision pour qu'on puisse cloner 
		// la vache sans probleme. Si la vache primaire recois des dégats alors tous les autres
		// clones auront la vie réduite de la vache primaire.
		var AddVache = (GameObject)Instantiate(VachePrefab, VacheSpawn.position, VacheSpawn.rotation);


	}
}
