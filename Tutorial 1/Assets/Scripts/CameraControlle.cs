using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlle : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void LateUpdate()
    {
        // runs everyframe but after everything has been calculated 
        transform.position = player.transform.position + offset;
    }
}
