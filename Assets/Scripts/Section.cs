using UnityEngine;
using System.Collections;

public class Section : MonoBehaviour {

	public UnityEngine.UI.Text Text;

	public float MinimumDistance=90,MaximumDistance=400;
	public bool SectionStart=false,SectionFinish=false;
	public string[] Message;
	int MessagePos;

	// Use this for initialization
	void Start () {
		MessagePos = 0;
	}
	// Update is called once per frame
	void Update () {
		if (!SectionStart&&Vector3.Distance (transform.position, (GameObject.FindWithTag("Player")).transform.position) < MaximumDistance) {
			SectionStart=true;
			Text.text="";
			Invoke( "section_box", 0f );
		}
		if (SectionStart&&!SectionFinish&&Vector3.Distance (transform.position, (GameObject.FindWithTag("Player")).transform.position) < MinimumDistance) {
			SectionFinish=true;
		}
		//gameObject.GetComponent<Renderer>().material.color.a = 0.5f;
		//Application.LoadLevel(Application.loadedLevel+1);
		//Destroy (this.gameObject);
	}
	public void section_box(){
		if(MessagePos<Message.Length)
		{Text.text+="\n";
			Text.text+=Message[MessagePos++];
			Invoke( "section_box", 2f );}
	}
}
