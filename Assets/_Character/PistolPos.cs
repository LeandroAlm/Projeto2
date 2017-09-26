using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPos : MonoBehaviour {

    private Transform pistol;
    public Transform hand;

    // Use this for initialization
    void Start()
    {
        pistol = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        pistol.position = hand.position;
        pistol.rotation = hand.rotation;
        pistol.rotation *= Quaternion.Euler(-50, -90, 180);
        //Debug.Log("rot= " + hand.rotation);
    }
}
