using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Interactable : MonoBehaviour {

	private GameObject info_box;
	private Outline outline;

	public GameObject playerCamera;

	void Start () {
		info_box = transform.GetChild(0).gameObject;
		outline = gameObject.GetComponent<Outline>();

	    // outline.OutlineMode = Outline.Mode.OutlineAll;
	    outline.OutlineColor = new Color(0F, 0.49F, 1F);
	    outline.OutlineWidth = 0f;
	}

	public void onGazeEnter () {
	    outline.OutlineWidth = 10f;
	}

	public void onGazeOut () {
	    outline.OutlineWidth = 0f;
		info_box.SetActive(false);
	}

	public void onClick () {
	    info_box.SetActive(true);
		// info_box.transform.rotation = Quaternion.AngleAxis(player.transform.eulerAngles.y, Vector3.up);
		info_box.transform.rotation = Quaternion.Euler(0, playerCamera.transform.eulerAngles.y, 0);
	}

}
