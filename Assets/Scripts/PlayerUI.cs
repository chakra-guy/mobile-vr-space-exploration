using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour {

	private bool open = false;

	public GameObject menu;

	void Update () {

		if ( transform.eulerAngles.x >= 45 ) {

			menu.SetActive(true);

			if (!open) {
				open = true;
				menu.transform.rotation = Quaternion.AngleAxis(transform.eulerAngles.y, Vector3.up);
			}

		} else {

			menu.SetActive(false);
			open = false;

		}
	}
}
