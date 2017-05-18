using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clock : MonoBehaviour {

	public int time = 600;
	public Text text;

	void Tick() {
		time--;
		text.text = (time / 60).ToString() + ":" + (time % 60).ToString();
	}

	public void Start() {
		InvokeRepeating ("Tick", 1, 1);
	}

}
