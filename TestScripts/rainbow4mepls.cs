//Chan and Tone made this stuff that'll probably not work.

using UnityEngine;
using System.Collections;

//The Main Functions
public class RainbowScript : MonoBehaviour
{
	int loop = 420;
	int timer = 0;
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.R))
		{
			while (loop < 69)
			{
				
				timer = 0;
				
				while (timer < 100)
				{
					gameObject.renderer.material.color = Color.white;
					timer = timer + 1;
				}
				
				timer = 0;
				
				while (timer < 100)
				{
					gameObject.renderer.material.color = Color.red;
					timer = timer + 1;
				}
				
				timer = 0;
				
				while (timer < 100)
				{
					gameObject.renderer.material.color = Color.yellow;
					timer = timer + 1;
				}
				
			//gameObject.renderer.material.color = Color.green;
			//gameObject.renderer.material.color = Color.blue;
			//gameObject.renderer.material.color = Color.magenta;
			}
		}
	}
}