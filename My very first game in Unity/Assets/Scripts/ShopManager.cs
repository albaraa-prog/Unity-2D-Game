using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public Ghost worker;
    public Ghost village;
    public Ghost trees;
    public Ghost crystal;
    public Ghost trap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShopClick(string type)
    {
        if (type == "worker")
        {
            Instantiate(worker);
        }
        if (type == "village")
        {
            Instantiate(village);
        }
        if (type == "trees")
        {
            Instantiate(trees);
        }
        if (type == "crystal")
        {
            Instantiate(crystal);
        }
        if (type == "trap")
        {
            Instantiate(trap);
        }

    }
}
