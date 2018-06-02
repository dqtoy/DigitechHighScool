using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {

	public static DataManager	instance = null;

	void Awake()
	{
		instance = this;

		Debug.Log("DataManager singlton instance is created..");
	}




	// // // //	// // // //// // // //// // // //// // // //// // // //// // // //
	// // // //






	// Use this for initialization
	void Start () {
	}



	//

	
}
