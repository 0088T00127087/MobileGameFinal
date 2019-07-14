using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{


    private Touch firstTouch = new Touch();
    public Camera myCamera;

    private float rotateCameraX = 0f;
    private float rotateCameraY = 0f;

    private Vector3 origCamerPos;

   
    public float rotateSpeed = 0.001f;
    public float direction = -1;


    // Start is called before the first frame update
    void Start()
    {
        origCamerPos = myCamera.transform.eulerAngles;
        rotateCameraX = origCamerPos.x;
        rotateCameraY = origCamerPos.y;
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 2)
        {

            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    firstTouch = touch;
                }
                else if (touch.phase == TouchPhase.Moved)
                {
                    //Calculate the position to move to
                    float deltaX = firstTouch.position.x - touch.position.x;
                    float deltaY = firstTouch.position.y - touch.position.y;

                    rotateCameraX -= deltaY * Time.deltaTime * rotateSpeed * direction;
                    rotateCameraY += deltaX * Time.deltaTime * rotateSpeed * direction;

                    rotateCameraX = Mathf.Clamp(rotateCameraX, -0f, 60f);
                    rotateCameraY = Mathf.Clamp(rotateCameraY, -60f, 60f);

                    myCamera.transform.eulerAngles = new Vector3(rotateCameraX, rotateCameraY, 0f);

                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    firstTouch = new Touch();
                }

            }
        }

        if(Input.touchCount == 1)
        {
            Vector2 screenPositionOfTouch = Input.touches[0].position;
            Ray laser = Camera.main.ScreenPointToRay(screenPositionOfTouch);
            Debug.DrawRay(laser.origin, 100 * laser.direction);
            RaycastHit info;
            if (Physics.Raycast(laser, out info))
            {

                //info.collider.GetComponent<SphereControl>().Bounce();
            }

        }

    }

}
