using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceManager : MonoBehaviour
{
    public int wood;
    public int blood;
    public int crystal;
    public static ResourceManager instance;
    public TMP_Text woodDisplay;
    public TMP_Text bloodDisplay;
    public TMP_Text crystalDisplay;

    private void Awake()
    {
        instance = this;     
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddResource(string resourceType, int amount)
    {
        if (resourceType == "wood") // Wood
        {
            wood += amount;
            if (woodDisplay != null)
            {
                woodDisplay.text = wood.ToString();
            }
        }
        if (resourceType == "blood") // Blood
        {
            blood += amount;
            if (bloodDisplay != null)
            {
                bloodDisplay.text = blood.ToString();
            }
        }
        if (resourceType == "crystal") // Crystal
        {
            crystal += amount;
            if (crystalDisplay != null)
            {
                crystalDisplay.text = crystal.ToString();
            }
        }
    }   
}
