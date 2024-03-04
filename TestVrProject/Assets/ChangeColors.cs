using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta;


public class ChangeColors : MonoBehaviour
{

    public Material[] materials;
    private int currentIndex = 0;
    private MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        
        if(materials.Length > 0)
        {
            mr.material = materials[currentIndex];
        }

       
    }

    public void ChangeColor()
    {
        if(materials.Length == 0)
        {
            Debug.Log("No Materials assigned");
            return;
        }

        currentIndex = (currentIndex + 1) % materials.Length;
        mr.material = materials[currentIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
