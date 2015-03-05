using UnityEngine;
using System.Collections;

public class ExampleVariablesAndFunctions : MonoBehaviour
{
	int myInt = 5;
	
	int MyFunction (int number)
	{
		int ret = myInt * number;
		return ret;
	}
}

