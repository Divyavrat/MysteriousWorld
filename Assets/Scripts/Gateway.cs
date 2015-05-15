using UnityEngine;
using System.Collections;

// Interactive Script of Level

public class Gateway : MonoBehaviour {

	public UnityEngine.Light Light;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Increases light intensity slowly
		Light.intensity += 0.05f;
	}
}
