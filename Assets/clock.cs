using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clock : MonoBehaviour {

	public int timeWhite = 600;
	public int timeBlack = 600;
	public Text textWhite;
	public Text textBlack;
	public Button button;
	public bool white = true;
	public Canvas settingsCanvas;

	void Start() {
		settingsCanvas.enabled = false;
	}

	void WhiteTick() {
		timeWhite--;
		textWhite.text = (timeWhite / 60).ToString() + ":" + (timeWhite % 60).ToString();
	}

	void BlackTick() {
		timeBlack--;
		textBlack.text = (timeBlack / 60).ToString() + ":" + (timeBlack % 60).ToString();
	}

	public void click() {

		ColorBlock cb = button.colors;

		if (white) {
			CancelInvoke ();
			InvokeRepeating ("WhiteTick", 1, 1);
			white = false;
			cb.normalColor = Color.black;
			cb.highlightedColor = Color.black;
			cb.pressedColor = Color.black;
			cb.disabledColor = Color.black;
			button.colors = cb;
			textWhite.color = Color.white;
			textBlack.color = Color.white;
		} else {
			CancelInvoke ();
			InvokeRepeating ("BlackTick", 1, 1);
			white = true;
			cb.normalColor = Color.white;
			cb.highlightedColor = Color.white;
			cb.pressedColor = Color.white;
			cb.disabledColor = Color.white;
			button.colors = cb;
			textWhite.color = Color.black;
			textBlack.color = Color.black;
		}
	}

}
