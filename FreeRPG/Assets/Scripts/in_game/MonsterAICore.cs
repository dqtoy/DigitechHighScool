using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAICore : MonoBehaviour {

	public enum Status
	{
		PATROL,

		AGGRO,

		ATTACK,

		DYING,

		SPWANNING,
	}

	public Status	status = Status.PATROL;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
