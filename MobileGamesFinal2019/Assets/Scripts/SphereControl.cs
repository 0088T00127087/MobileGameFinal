using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{

    //GameObject sphere;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector2 screenPositionOfTouch = Input.touches[0].position;
            Ray laser = Camera.main.ScreenPointToRay(screenPositionOfTouch);
            Debug.DrawRay(laser.origin, 100 * laser.direction);
            RaycastHit info;
            if (Physics.Raycast(laser, out info))
            {

                print("touched ball");
                Bounce();
            
            }
        }

        if (Input.touchCount > 2)
            transform.position += Vector3.right;

    }


    void Bounce()
    {
        transform.position += Vector3.up;
    }
}

    

