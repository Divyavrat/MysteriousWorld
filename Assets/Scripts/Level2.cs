using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {

	public UnityEngine.UI.Text Text;

	// Use this for initialization
	void Start () {
		Invoke( "box1", 0f );
		Invoke( "box2", 1f );
		Invoke( "box3", 3f );
		Invoke( "box4", 5f );
		Invoke( "box5", 7f );
	}
	
	// Update is called once per frame
	void Update () {
	}
	void box1(){
		Text.text=("Live with me");
	}
	void box2(){
		Text.text+=("\nFor I am life");
	}
	void box3(){
		Text.text+=("\nAnd I shall breathe a new life into you");
	}
	void box4(){
		Text.text+=("\nI am evergoing life. Never stopping.");
	}
	void box5(){
		Text.text+=("\nI shall lead you.");
	}
}
