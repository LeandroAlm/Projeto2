using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour {
    
    private Transform player;
    private Terrain terreno;
    public TreeInstance treeInstance;
    private GameObject go;
    private detailScript detailScript;
    
    Ray ray;
    Vector3 forward;
    int wood = 0;
    int stone = 0;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Transform>();
	}
	
	void Update ()
    {
        RaycastHit hit;
		
        forward = transform.TransformDirection(Vector3.forward * 10 + new Vector3(0,1,0));
        Debug.DrawRay(transform.position, forward, Color.green);
        

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            
            if (Physics.Raycast(ray, out hit))
            {
                detailScript = hit.rigidbody.gameObject.GetComponent<detailScript>();
                Debug.Log("Nome " + detailScript.Name);
                if (hit.collider.gameObject.GetComponent<Terrain>() == null)
                    
                    return;
                else if (hit.transform.position == treeInstance.position)
                {
                    if (detailScript.Name == "Tree")
                    {
                        wood++;
                        Debug.Log("wood: " + wood);
                    }
                    if (detailScript.Name == "Stone")
                    {
                        stone++;
                        Debug.Log("Stone: " + wood);
                    }
                }
            }
        }
    }
}
