using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{

    GameObject obj = null;
    
    Vector3 positionOfObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 1)
        {
            Touch input = Input.GetTouch(0);
            positionOfObject = input.position;
            print(positionOfObject);
        }

        



        
    }
}
