﻿using UnityEngine;
using System.Collections;

public class GUIControl : MonoBehaviour {

	void Update () {
		if (Character.victoriousTeam == '0') {
			guiText.text = Character.killsA + " x " + Character.killsB;
		}
		else {
			if (Character.victoriousTeam == 'v')
				guiText.text = Character.killsA + " x " + Character.killsB +"\nVolante Won";
			else {
				guiText.text = Character.killsA + " x " + Character.killsB +"\nCangaceiros Won";
			}
		}
	}
}
