using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour {

	public Canvas settingsCanvas;

	public void settingsClick() {
		settingsCanvas.enabled = true;
	}
}
