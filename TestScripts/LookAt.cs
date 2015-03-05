using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour
{
	public Transform target;
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Q))
			transform.LookAt(target);
	}
}

