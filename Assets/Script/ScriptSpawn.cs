using UnityEngine;
using System.Collections;

public class ScriptSpawn : MonoBehaviour {
    
	public Player player;
   	void OnTriggerEnter (Collider Other)
    {
		if (player.vie == 0) {
			Debug.Log (player.vie);
			if (Other.gameObject.tag == "Player") {
				Other.gameObject.transform.position = GameObject.Find ("SpawnPoint").transform.position;
				player.vie = 100;
            
			}	
		}
	}		
}
