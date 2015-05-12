using UnityEngine;
using System.Collections;

// Script for Player Control and animations
public class CSController : MonoBehaviour {

	private Animator[] playerGroup; 
	private string[] animClipNameGroup;
	private int currentNumber;
		
	public float walkSpeed= 10f;
	public float rotateSpeed= 175f;
	public float jumpHeight= 50f;

	private float currentrunSpeed;
	public float runSpeedMultiplyer= 1.5f;

	public bool cameraFar = true;

	// Use this for initialization
	void Start () {

		animClipNameGroup = new string[] {
			"Basic_Idle",
			"Basic_Run_01",
			"Basic_Run_02",
			"Basic_Run_03",
			"Basic_Walk_01",
			"Basic_Walk_02",
			"Etc_Walk_Zombi_01"
		};

		currentNumber = 0;
		currentrunSpeed = runSpeedMultiplyer;

		playerGroup = GameObject.Find ("PlayerGroup").transform.GetComponentsInChildren<Animator>();

		UpdateAnimation();
	}

	void UpdateAnimation()
	{
		if(currentNumber < 0 )
		{
			currentNumber = animClipNameGroup.Length - 1;
		}
		
		
		if(currentNumber == animClipNameGroup.Length)
		{
			currentNumber = 0;
		}
		
		for(int i = 0; i < playerGroup.Length; i++)
		{
			playerGroup[i].speed = 1f;
			playerGroup[i].Play(animClipNameGroup[currentNumber]);
		}
	}

	string GetInputDown()
	{
		if (Input.GetButton ("Horizontal")) {
			if (Input.GetAxis ("Horizontal") > 0) {
				return "right";
			}
			else{
				return "left";
			}
				}
		else if (Input.GetButton ("Vertical")) {
			if (Input.GetAxis ("Vertical") > 0) {
				return "down";
			}
			else{
				return "up";
			}
		}
		return "null";
	}
	bool GetInputUp()
	{
		bool UpKeys=false;
		UpKeys=(Input.GetButtonUp ("Horizontal")||Input.GetButtonUp ("Vertical"));
		return UpKeys;
	}

	void ControlPlayer()
	{
			//Switch Camera location
			if (Input.GetKeyDown ("f")) {
						cameraFar = !cameraFar;
			if(cameraFar){
				(GameObject.FindWithTag("MainCamera")).transform.position.Set(0f,0f,-2.5f);
			}
			else
				(GameObject.FindWithTag("MainCamera")).transform.position.Set(0f,0f,0f);
				}
						
			//Moves Player Foward
			if(Input.GetKey("w"))
				transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
			
			//Moves Player Back
			if(Input.GetKey("s"))
				transform.Translate(Vector3.back * Time.deltaTime * walkSpeed);
			
			//Moves Player Right
			if(Input.GetKey("d"))
				transform.Translate(Vector3.right * Time.deltaTime * walkSpeed);
			
			//Moves Player Left
			if(Input.GetKey("a"))
				transform.Translate(Vector3.left * Time.deltaTime * walkSpeed);
			
			//Rotates Player Right
			if(Input.GetKey("right"))
				transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
			
			//Rotates Plater Left
			if(Input.GetKey("left"))
				transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed);
			
			//Player Jumps
			if(Input.GetKeyDown("space"))
				transform.Translate(Vector3.up * Time.deltaTime * jumpHeight);
			
			//Player Runs
			if(Input.GetKey("up"))
			transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed * currentrunSpeed);

			//Player Runs
			if(Input.GetKey("down"))
			transform.Translate(Vector3.back * Time.deltaTime * walkSpeed * currentrunSpeed);
	}

	void Control()
	{
		ControlPlayer();
		if (GetInputDown()=="down"||GetInputDown()=="up"||GetInputDown()=="left"||GetInputDown()=="right")
		{
			if(Input.GetKey(KeyCode.LeftShift)||Input.GetKey(KeyCode.RightShift))
			{
				//Fast Run
				currentrunSpeed = runSpeedMultiplyer*5;
				currentNumber=3;
			}
			else if(Input.GetKey(KeyCode.LeftAlt)||Input.GetKey(KeyCode.RightAlt))
			{
				//Walk
				currentrunSpeed = runSpeedMultiplyer/2;
				currentNumber=4;
			}
			else{
				//Run
				currentrunSpeed = runSpeedMultiplyer;
				currentNumber=2;
			}
			UpdateAnimation();
		}
		if (GetInputUp())
		{
			currentNumber=0;
			UpdateAnimation();
		}
	}
	void Update()
	{
		Control();
	}
	
	void OnGUI()
	{
		/*if(GUI.Button(new Rect(50,50,50,50),"<"))
		{currentNumber--;UpdateAnimation();}
		if(GUI.Button(new Rect(160,50,50,50),">"))
		{currentNumber++;UpdateAnimation();}
		GUI.Label (new Rect(240, 50, 200,100), animClipNameGroup[currentNumber].ToString() );
		*/
	}
}
