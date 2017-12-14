using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int vie, degat;
	public GameObject BulletPrefab;
	public Transform BulletSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)){
			Fire();
		}

		// Respawn
		if (vie == 0) {
			if (gameObject.tag == "Player") {
				gameObject.transform.position = GameObject.Find ("SpawnPoint").transform.position;
				vie = 100;
			}	
		}
	}


	void Fire(){
		
		var bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 7;
		Destroy(bullet, 2.0f);

	}

}
