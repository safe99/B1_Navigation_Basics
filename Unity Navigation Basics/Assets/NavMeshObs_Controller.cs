using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshObs_Controller : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("left"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("up"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
