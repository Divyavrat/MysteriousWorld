using UnityEngine;
using System.Collections;

public class DetectFinish : MonoBehaviour {
	public float MinimumDistance=150;
	bool SectionFinish=false;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		// To detect when the level is finshed
		// and load next level
		if (!SectionFinish&&Vector3.Distance (transform.position, (GameObject.FindWithTag("Player")).transform.position) < MinimumDistance) {
			SectionFinish=true;
			//Application.LoadLevel(Application.loadedLevel+1);
			//Destroy (this.gameObject);
			GetComponent<Renderer>().material.color = new Vector4(1,1,1,0.2f);
			//gameObject.GetComponent<Renderer>().material.color.a = 0.5f;
			}
	}
}
