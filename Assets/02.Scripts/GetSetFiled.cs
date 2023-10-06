using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSetFiled : MonoBehaviour
{
	//private int myField;

	//public int GetMyField() 
	//{ 
	//	return myField; 
	//}

	//private int myField;

	//public int MyField
	//{
	//	get { return myField; }
	//	set { myField = value; }
	//}

	public int myField { get; private set; }
}