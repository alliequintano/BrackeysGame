using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    public float exp;

	// Use this for initialization
	void Start ()
    {
        exp = 0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        exp += 1 * Time.deltaTime;
        Debug.Log(exp);
	}
}
