using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour {

    public Transform tree;
    private Transform player;
    public Transform terreno;
    public bool farm;

    int wood = 0;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Vector3.Distance(player.transform.position, tree.transform.position) < 2)
        {
            if (farm == true)
            {
                wood++;
                farm = false;
            }
        }
        Debug.Log(wood + " dis: " + Vector3.Distance(player.transform.position, tree.transform.position));


        terreno.ter
    }
}
