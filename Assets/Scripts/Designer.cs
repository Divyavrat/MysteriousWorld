using UnityEngine;
using System.Collections;

public class Designer : MonoBehaviour {

	public UnityEngine.UI.Text Design;

	// Use this for initialization
	void Start () {
		design();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	int currentDesign='A';
	void design(){
		currentDesign += 1;
		if(currentDesign>'Z')currentDesign='A';
		Design.text = (currentDesign).ToString ().Remove (1);
		Invoke("design", 0.5f);
	}
}
