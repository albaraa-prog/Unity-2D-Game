using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject ObjectToSpawn; // The object to spawn when the ghost is clicked
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Set z to 0 for 2D
        transform.position = mousePosition;

        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {        
            Instantiate(ObjectToSpawn, transform.position, Quaternion.identity); 
            Destroy(gameObject); // Destroy the ghost after spawning the object

        }
    }

   
}
