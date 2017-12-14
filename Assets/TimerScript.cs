using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	[SerializeField]
	private float timer;

	private Text t;

	// Use this for initialization
	void Start () {
		t = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		// Permet d'initialiser un timer et de faire apparaitre que 2 chiffres
		timer += Time.deltaTime;
		t.text = (timer.ToString()).Remove(2);

	}

	public void Reset()
	{
		timer = 0;
	}
}