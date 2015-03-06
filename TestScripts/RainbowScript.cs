//Rainbow Script by 5on
using UnityEngine;
using System.Collections;

//"Global" Variables
public static class Variables{
	public static int loop = 420}

//The Main Functions
public class RainbowScript : MonoBehaviour{
	void Update(){
		 if (Input.GetKeyDown(KeyCode.R)){
			while (loop < 69)
			//Double rainbow all the way
			gameObject.renderer.material.color = Color.red;
			gameObject.renderer.material.color = Color.orange;
			gameObject.renderer.material.color = Color.yellow;
			gameObject.renderer.material.color = Color.green;
			gameObject.renderer.material.color = Color.blue;
			gameObject.renderer.material.color = Color.purple;}}}

