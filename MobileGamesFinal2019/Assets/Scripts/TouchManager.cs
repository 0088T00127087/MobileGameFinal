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
        if (Input.touchCount == 0)
        {
            print("No touches detected");
            
        }
        if(Input.touchCount == 1)
        {
            //Test to get if touch is greater than zero
            //print("Touch count is greater than zero");
            // Call the Destroy Method
            Destroy();
        }

        if(Input.touchCount == 2)
        {

        }
            


    }

    internal void Destroy()
    {
        // To hit the sphere and destroy it
        Vector2 screenPositionOfTouch = Input.touches[0].position;
        Ray laser = Camera.main.ScreenPointToRay(screenPositionOfTouch);
        Debug.DrawRay(laser.origin, 100 * laser.direction);
        RaycastHit info;
        if (Physics.Raycast(laser, out info))
        {
            // Note the plane onto which the balls drop is also a game object and when detected by a touch it is destroyed
            // Try a differenct method to only use the hit on the balls.
            // Give them a tag of destroyable.

            Destroy(info.transform.gameObject);
        }

    }
   





}
