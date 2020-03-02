using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
   
    private Color[] bolas = new Color[] { Color.green, Color.blue, Color.red };
    void Update()
    {
        int i = 1;
      
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray))
                {
                    GetComponent<Renderer>().material.color= bolas[i];
                }
            }
        }
    }
}
