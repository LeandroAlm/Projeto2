using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour {
    
    private Transform player;
    private Terrain terreno;
    public TreeInstance treeInstance;
    //public bool farm;
    
    Ray ray;
    Vector3 forward;
    int wood = 0;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Transform>();
        //terreno = GetComponent<Terrain>();
        
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
        
        

        //ray.origin = player.transform.position;
        //ray.direction = player.transform.forward;
        forward = transform.TransformDirection(Vector3.forward * 10 + new Vector3(0,1,0));
        Debug.DrawRay(transform.position, forward, Color.green);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (terreno.tag == "Tree")
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.GetComponent<Terrain>() == null)
                    return;

                //terreno = hit.collider.gameObject.GetComponent<Terrain>();
                //float groundHeight = terreno.SampleHeight(hit.point);
                Debug.Log(hit.collider.gameObject.GetComponent<Terrain>());
            
            
                if (hit.transform.position == treeInstance.position)
                {
                    wood++;
                    Debug.Log(wood);
                }
            }
        }
    }
}
