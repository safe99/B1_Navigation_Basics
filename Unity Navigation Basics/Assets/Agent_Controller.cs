using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent_Controller : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera mainCamera;
    //private bool selected = true;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Mouse is over: " + hit.collider.name);
                GameObject hitObject = hit.transform.root.gameObject;
               // selectObject(hitObject);
            }

        }


        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }

        }

        if(agent.remainingDistance <= agent.stoppingDistance)
        {
            agent.Move(Vector3.zero);
        }

        
    }

/*    void selectObject(GameObject obj)
    {
        if (this.selected)
        {
            this.selected = false;
            Debug.Log("Agent has been selected to false");
        }
        else this.selected = true;
        Debug.Log("Agent has been selected to true");
    }*/
}
