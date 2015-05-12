using UnityEngine;
using System.Collections;

// Interactive Script of Level

public class Level1 : MonoBehaviour {

	public UnityEngine.UI.Text Text;
	public UnityEngine.UI.Text Design;
	public UnityEngine.Light Light;

	// Use this for initialization
	void Start () {
		design ();
		Invoke( "box1", 0f );
		Invoke( "box2", 1f );
		Invoke( "box3", 3f );
		Invoke( "box4", 5f );
		Invoke( "box5", 7f );
	}
	
	// Update is called once per frame
	void Update () {
		// Increases light intensity slowly
		Light.intensity += 0.05f;
	}

	int currentDesign='A';
	void design(){
		currentDesign += 1;
		if(currentDesign>'Z')currentDesign='A';
		Design.text = (currentDesign).ToString ().Remove (1);
		Invoke("design", 0.5f);
		}
	void box1(){
		Text.text=("Come to me");
	}
	void box2(){
		Text.text+=("\nI am the twisted block");
	}
	void box3(){
		Text.text+=("\nHere I am");
	}
	void box4(){
		Text.text+=("\nI am the mystery of your life");
	}
	void box5(){
		Text.text+=("\nI shall devour you. I shall induce you.");
	}
}
