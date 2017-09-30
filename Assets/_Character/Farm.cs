using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour {

    public Transform tree;
    private Transform player;
    public Terrain terreno;
    //public bool farm;
    
    Ray ray;
    Vector3 forward;
    int wood = 0;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Transform>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
        float distance;
		//if (Vector3.Distance(player.transform.position, tree.transform.position) < 2)
  //      {
  //          if (farm == true)
  //          {
  //              wood++;
  //              farm = false;
  //          }
  //      }
        Debug.Log(wood);

        //ray.origin = player.transform.position;
        //ray.direction = player.transform.forward;
        forward = transform.TransformDirection(Vector3.forward * 10 + new Vector3(0,1,0));
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, forward, Color.green);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (terreno.tag == "Tree")
        if (Physics.Raycast(ray, out hit))
        {
            //if (hit.rigidbody != null)
            Debug.Log(hit.collider.tag);
            
            if (Input.GetMouseButtonDown(0))
                if (hit.collider.tag == terreno.tag)
                    wood++;
        }
    }
}
