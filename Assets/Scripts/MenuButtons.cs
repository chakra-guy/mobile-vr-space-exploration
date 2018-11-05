using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour {

	private bool childExists = false;
	private Material baseMaterial;

	public Material hoverMaterial;

	void Start () {

		baseMaterial = transform.GetComponent<MeshRenderer>().material;

		if ( transform.GetChild(0) != null ) {
			childExists = true;
		}

	}

	public void ButtonHover() {

		transform.GetComponent<MeshRenderer>().material = hoverMaterial;

		if ( childExists ) {
			transform.GetChild(0).GetComponent<MeshRenderer>().material = hoverMaterial;
		}

	}

	public void ButtonHoverOver() {

		transform.GetComponent<MeshRenderer>().material = baseMaterial;

		if ( childExists ) {
			transform.GetChild(0).GetComponent<MeshRenderer>().material = baseMaterial;
		}

	}

	public void GoToIntro() {
		Application.LoadLevel("Intro");
	}
	public void GoToEarth() {
		Application.LoadLevel("Earth");
	}
	public void GoToMoon() {
		Application.LoadLevel("Moon");
	}
}
