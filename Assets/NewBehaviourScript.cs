using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		

	}
	void OnGUI () {
		float angle = 10;
		Vector3 axis = new Vector3(0,1,0);
		float anglePerUpdate = 2f;
		//Create a new Button at location 0,0, with a size of 100, 20. 
		//The text in the button will read "Rotate Once"
		if(GUI.Button(new Rect(88,-73,160,30), "Right")) {
			//if button is pressed, perform the following
			//rotate the object to a specified angle rotating around the axis specified
			this.transform.rotation = Quaternion.AngleAxis(angle, axis);
		}

		//create another button below "Rotate Once".
		//this is a  RepeatButton that will continue to perform its action every update
		/*if(GUI.RepeatButton(new Rect(0,25,100,20), "Rotate Continuous")) {
			//if button is pressed, perform the following
			//rotate the object at a specified speed, around the specified axis
			//take the existing rotation and add a little bit to it
			this.transform.rotation = 
				this.transform.rotation * Quaternion.AngleAxis(anglePerUpdate, axis);
		}*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
