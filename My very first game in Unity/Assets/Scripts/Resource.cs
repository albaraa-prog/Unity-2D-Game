using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public int resourceAmount; // Amount of resource available
    public string resourceType; // Type of resource (e.g., wood, stone, etc.)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resourceAmount <= 0) {
            Destroy(gameObject); // Destroy the resource object when amount is zero
        }

    }
}
