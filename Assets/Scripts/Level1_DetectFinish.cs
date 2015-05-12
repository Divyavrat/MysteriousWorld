using UnityEngine;
using System.Collections;

public class Level1_DetectFinish : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	bool levelFinish=false;
	// Update is called once per frame
	void Update () {
		// To detect when the level is finshed
		// and load next level
		if (!levelFinish&&Vector3.Distance (transform.position, (GameObject.FindWithTag("Player")).transform.position) < 90) {
			levelFinish=true;
			Application.LoadLevel(Application.loadedLevel+1);
			}
	}
}
