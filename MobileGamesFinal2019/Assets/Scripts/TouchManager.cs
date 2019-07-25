using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    // this will be used for catching the sphere
    GameObject heldObject = null;

    // This is to get the single touch to move the a ball object
    private Touch firstTouch = new Touch();

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

        // Using the phases of a touch begin
        if(Input.touchCount == 1)
        {
            //Test to get if touch is greater than zero
            //print("Touch count is greater than zero");
            // Call the Destroy Method
            //Destroy();


            Ray oneTouchLazor = MyLazerPointer();
            RaycastHit info;

            //if(Physics.Raycast(oneTouchLazor.origin, oneTouchLazor.direction, out info))
            //{
            //    heldObject = info.transform.gameObject;
            //}
            //else if(Input.touchCount ==1  && heldObject)
            //{
            //    Vector3 positionObjectMovedTo = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
            //    heldObject.transform.position = new Vector3(positionObjectMovedTo.x, positionObjectMovedTo.y, heldObject.transform.position.z);
            //}
            //else if(Input.touchCount == 0 && heldObject)
            //{
            //    heldObject = null;
            //}

            /*
             * To grap a ball with touch*/
             if(Input.touchCount == 1)
            {
                foreach (Touch touch in Input.touches)
                {
                    if (touch.phase == TouchPhase.Began)
                    {

                    }
                    else if(touch.phase == TouchPhase.Moved)
                    {

                    }
                    else if (touch.phase == TouchPhase.Ended)
                    {
                        
                    }
                }

            }
           










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

     Ray MyLazerPointer()
    {
        Vector2 screenPositionOfTouch = Input.touches[0].position;
        Ray laser = Camera.main.ScreenPointToRay(screenPositionOfTouch);
        
        Ray mylazer = new Ray(laser.origin, 100 * laser.direction);
        return mylazer;
    }
   





}
