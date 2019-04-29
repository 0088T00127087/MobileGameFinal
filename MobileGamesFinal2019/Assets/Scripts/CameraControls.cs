using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Start point
    private Vector2 worldStartPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector2 screenPositionOfTouch = Input.touches[0].position;
            Ray laser = Camera.main.ScreenPointToRay(screenPositionOfTouch);
            Debug.DrawRay(laser.origin, 100 * laser.direction);
            RaycastHit info;
            // if (Physics.Raycast(laser, out info))
            // {

            //     info.collider.GetComponent<>().moveUp;
            //  }


            // Phases for camera Movement
            if (Input.touchCount == 1)
            {
                Touch currentTouch = Input.GetTouch(0);

                if (currentTouch.phase == TouchPhase.Began)
                {
                    //this.worldStartPoint = this.getWorldPoint(currentTouch.position);

                    // setting world start point to position of camera
                    this.worldStartPoint = Camera.main.gameObject.transform.position;
                }

                if (currentTouch.phase == TouchPhase.Moved)
                {
                    Vector2 worldDelta = this.getWorldPoint(currentTouch.position) - this.worldStartPoint;

                    Camera.main.transform.Translate(
                        -worldDelta.x,
                        0,
                        0
                    );
                }
            }

           






        }


    }

  

}
