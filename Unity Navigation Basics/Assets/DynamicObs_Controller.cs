using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DynamicObs_Controller : MonoBehaviour
{
    NavMeshObstacle obs;
    Vector3 destination;
    public Transform waypoint_start;
    public Transform waypoint_back;
    bool start = true;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        obs = GetComponent<NavMeshObstacle>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (start)
        {
            pos.z += speed * Time.deltaTime;
            if(pos.z >= waypoint_start.position.z)
            {
                start = false;
            }
        }
        else
        {
            pos.z -= speed * Time.deltaTime;
            if (pos.z <= waypoint_back.position.z)
            {
                start = true;
            }
        }

        transform.position = pos;

    }
}
