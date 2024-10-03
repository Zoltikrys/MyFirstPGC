using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour
{
    public Color []colors;
    public Renderer rendering;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeColor", 0f, 1f);
    }

    void ChangeColour()
    {
        rendering.material.color = colors[Random.Range(0, colors.Length -1)];
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
