using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsitolPos : MonoBehaviour {

    private Transform pistol;
    public Transform hand;

    // Use this for initialization
    void Start () {
        pistol = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        pistol.position = hand.position;
        pistol.rotation = hand.rotation;
        Debug.Log("rot= " + hand.rotation);
	}
}