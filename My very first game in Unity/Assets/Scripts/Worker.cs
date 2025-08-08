using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    bool isSelected;
    public LayerMask resourcesLayer;
    public float collectDistance;
    public float timeBetweenCollect = 1f;
    public int collectAmount = 1;
    float nextCollectTime;
    Resource currentResource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected == true)
        {
            // Move the worker to the mouse position
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Set z to 0 for 2D
            transform.position = mousePosition;
        }
        else
        {
            Collider2D hitColliders = Physics2D.OverlapCircle(transform.position, collectDistance, resourcesLayer);
            if (hitColliders != null)
            {
                currentResource = hitColliders.GetComponent<Resource>();
            }
            else
            {
                currentResource = null;
            }

            if (currentResource != null)
            {
                if (Time.time >= nextCollectTime)
                {
                    nextCollectTime = Time.time + timeBetweenCollect;
                    currentResource.resourceAmount -= collectAmount;
                }
            }
        }
    }

    private void OnMouseDown()
    {
        isSelected = true;
    }
    private void OnMouseUp()
    {
        isSelected = false;
    }
}
