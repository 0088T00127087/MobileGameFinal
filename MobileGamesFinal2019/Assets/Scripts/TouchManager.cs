using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // To get the touch input
        if (Input.touchCount > 0)
        {
            //Test to get if touch is greater than zero
           print("Touch count is greater than zero");
        }
        else
            print("No touches detected");


        // To hit the spere
        



    }





}
