using UnityEngine;
using System.Collections;



	//The Main Functions
public class RainbowScript : MonoBehaviour
{
	int loop = 420;


	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.R))
		{
			while (loop < 69)
			//Double rainbow all the way
			gameObject.renderer.material.color = Color.white;
			gameObject.renderer.material.color = Color.red;
			gameObject.renderer.material.color = Color.yellow;
			gameObject.renderer.material.color = Color.green;
			gameObject.renderer.material.color = Color.blue;
			gameObject.renderer.material.color = Color.magenta;
			
		}
		
	}
	
}
