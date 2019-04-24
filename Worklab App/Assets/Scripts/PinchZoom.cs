using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PinchZoom:MonoBehaviour {


    // THIS SCRIPT IS FOR PINCH TO ZOOM = USING 2 FINGERS TO ZOOM BY PINCHING OR STRETCHING.
    // THERES STILL SOME BUGS HERE AND THERE REGARDING THIS SCRIPT AND I CANT FIGURE OUT WHY, IT SEEMS TO SPAS OUT WHEN IT ZOOMS OUT (SPASM) BUT ZOOMING IN SEEMS FINE.
    // 
    // SOME PROJECTS HAVE PICTURE SIZES OF 2080 BY 1080 OR MORE, THIS PROJECTS TRY TO SCALE IT DOWN INSTEAD OF USING THE TRANSFORM POSITION NEGATIVE OR POSITIVE Z AXIS LIKE ME
    // I SHOULD NOT HAVE USED THAT CAUSE IT CAUSED THE PICTURES TO BE FAR AWAY AND IT DOESNT ZOOM PROPERLY AKA SLOW OR TOO FAST FOR SOME PROJECTS
    // THE SMALLER THE PICTURE SIZES THE FASTER IT PANS VICE VERSA

    // SO IN THE FUTURE PLEASE OPTIMIZE THE APP BY SCALING ALL THE BIG PROJECTS DOWN TO FIT THE CAMERA. INSTEAD OF PUSHING IT FURTHER AWAY LIKE I PUSH MY PROBLEMS TO YOU :D JK WE DONT HAVE ENOUGH TIME TO DO IT RIGHT.

    // you can change those that are not private to public for easy access and change but rmber to keep it consistent for all projects thats why i recommend changing from here  - Joseph


    int speed = 4;
    Camera selectedCamera;
    //float MINSCALE = 2.0F;
    //float MAXSCALE = 5.0F;
    float minPinchSpeed = 5.0F;
    float varianceInDistances = 2.0F;
    private float touchDelta = 0.0F;
    private Vector2 prevDist = new Vector2(0,0);
    private Vector2 curDist = new Vector2(0,0);
    private float speedTouch0 = 0.0F;
    private float speedTouch1 = 0.0F;

    // Use this for initialization
    void Start() {

        selectedCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update() {

        // you should know this, you are already at least year 2.
        // if there are 2 touches on screen. zoom in and out is enabled. - Joseph

        if(Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved) {

            curDist = Input.GetTouch(0).position - Input.GetTouch(1).position; //current distance between finger touches
            prevDist = ((Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition) - (Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition)); //difference in previous locations using delta positions
            touchDelta = curDist.magnitude - prevDist.magnitude;
            speedTouch0 = Input.GetTouch(0).deltaPosition.magnitude / Input.GetTouch(0).deltaTime;
            speedTouch1 = Input.GetTouch(1).deltaPosition.magnitude / Input.GetTouch(1).deltaTime;


            if((touchDelta + varianceInDistances <= 1) && (speedTouch0 > minPinchSpeed) && (speedTouch1 > minPinchSpeed)) {

                selectedCamera.fieldOfView = Mathf.Clamp(selectedCamera.fieldOfView + (1 * speed),15,90);
            }

            if((touchDelta + varianceInDistances > 1) && (speedTouch0 > minPinchSpeed) && (speedTouch1 > minPinchSpeed)) {

                selectedCamera.fieldOfView = Mathf.Clamp(selectedCamera.fieldOfView - (1 * speed),15,90);
            }

        } 
    }


    // to prove that i was trying my best to fix the god damn pinch which isn't working right lmao I CRI EVERYTIME. 


    //public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
    //public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.


    ////void Update()
    ////{
    ////    // If there are two touches on the device...
    ////    if (Input.touchCount == 2)
    ////    {
    ////        // Store both touches.
    ////        Touch touchZero = Input.GetTouch(0);
    ////        Touch touchOne = Input.GetTouch(1);

    ////        // Find the position in the previous frame of each touch.
    ////        Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
    ////        Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

    ////        // Find the magnitude of the vector (the distance) between the touches in each frame.
    ////        float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
    ////        float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

    ////        // Find the difference in the distances between each frame.
    ////        float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

    ////        // If the camera is orthographic...
    ////        if (GetComponent<Camera>().isOrthoGraphic)
    ////        {
    ////            // ... change the orthographic size based on the change in distance between the touches.
    ////            camera.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;

    ////            // Make sure the orthographic size never drops below zero.
    ////            camera.orthographicSize = Mathf.Max(camera.orthographicSize, 0.1f);
    ////        }
    ////        else
    ////        {
    ////            // Otherwise change the field of view based on the change in distance between the touches.
    ////            camera.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;

    ////            // Clamp the field of view to make sure it's between 0 and 180.
    ////            camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, 0.1f, 179.9f);
    ////        }
    ////    }
    ////}

    ////-------------------------------------------------------------------------------------------------------------



    //public Canvas canvas; // The canvas
    //public float zoomSpeed = 0.5f;        // The rate of change of the canvas scale factor

    //public float _resetDuration = 3.0f;
    //float _durationTimer = 0.0f;

    //float _startScale = 0.0f;

    //void Start() {
    //    _startScale = canvas.scaleFactor;
    //}

    //void Update() {
    //    // If there are two touches on the device...
    //    if(Input.touchCount == 2) {
    //        // Store both touches.
    //        Touch touchZero = Input.GetTouch(0);
    //        Touch touchOne = Input.GetTouch(1);


    //        // Find the position in the previous frame of each touch.
    //        Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
    //        Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

    //        // Find the magnitude of the vector (the distance) between the touches in each frame.
    //        float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
    //        float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

    //        // Find the difference in the distances between each frame.
    //        float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

    //        // ... change the canvas size based on the change in distance between the touches.
    //        canvas.scaleFactor -= deltaMagnitudeDiff * zoomSpeed;

    //        // Make sure the canvas size never drops below 0.1
    //        canvas.scaleFactor = Mathf.Max(canvas.scaleFactor,_startScale);
    //        canvas.scaleFactor = Mathf.Min(canvas.scaleFactor,_startScale * 3.0f);

    //        _durationTimer = 0.0f;
    //        print(touchOne);
    //    } else {
    //        _durationTimer += Time.deltaTime;

    //        if(_durationTimer >= _resetDuration) {
    //            canvas.scaleFactor = _startScale;
    //        }
    //    }
    //}



    //private static readonly float PanSpeed = 20f;
    //private static readonly float ZoomSpeedTouch = 0.1f;
    //private static readonly float ZoomSpeedMouse = 0.1f;

    //private static readonly float[] BoundsX = new float[] { -2f,2f };
    //private static readonly float[] BoundsZ = new float[] { -6f,-2f };
    //private static readonly float[] ZoomBounds = new float[] { 10f,85f };

    //private Camera cam;

    ////public static Vector3 originalPos;

    //private Vector3 lastPanPosition;
    //private int panFingerId; // Touch mode only

    //private bool wasZoomingLastFrame; // Touch mode only
    //private Vector2[] lastZoomPositions; // Touch mode only

    //void Awake() {
    //    cam = GetComponent<Camera>();

    //    originalPos = transform.position;

    //}

    //void Update() {

    //    if(Input.touchSupported && Application.platform != RuntimePlatform.WebGLPlayer) {
    //        HandleTouch();
    //    } else {
    //        HandleMouse();
    //    }
    //}S

    //void HandleTouch() {
    //    switch(Input.touchCount) {

    //        case 1: // Panning
    //            wasZoomingLastFrame = false;

    //            // If the touch began, capture its position and its finger ID.
    //            // Otherwise, if the finger ID of the touch doesn't match, skip it.
    //            Touch touch = Input.GetTouch(0);
    //            if(touch.phase == TouchPhase.Began) {
    //                lastPanPosition = touch.position;
    //                panFingerId = touch.fingerId;
    //            } else if(touch.fingerId == panFingerId && touch.phase == TouchPhase.Moved) {
    //                PanCamera(touch.position);
    //            }
    //            break;

    //        case 2: // Zooming
    //            Vector2[] newPositions = new Vector2[] { Input.GetTouch(0).position,Input.GetTouch(1).position };
    //            if(!wasZoomingLastFrame) {
    //                lastZoomPositions = newPositions;
    //                wasZoomingLastFrame = true;
    //            } else {
    //                ////    Zoom based on the distance between the new positions compared to the
    //                ////    distance between the previous positions.
    //                float newDistance = Vector2.Distance(newPositions[0],newPositions[1]);
    //                float oldDistance = Vector2.Distance(lastZoomPositions[0],lastZoomPositions[1]);
    //                float offset = newDistance - oldDistance;

    //                ZoomCamera(offset,ZoomSpeedTouch);

    //                lastZoomPositions = newPositions;

    //            }
    //            break;

    //        default:
    //            wasZoomingLastFrame = false;
    //            break;
    //    }
    //}

    //void HandleMouse() {
    //    // On mouse down, capture it's position.
    //    // Otherwise, if the mouse is still down, pan the camera.
    //    if(Input.GetMouseButtonDown(0)) {
    //        lastPanPosition = Input.mousePosition;
    //    } else if(Input.GetMouseButton(0)) {
    //        PanCamera(Input.mousePosition);
    //    }

    //    // Check for scrolling to zoom the camera
    //    float scroll = Input.GetAxis("Mouse ScrollWheel");
    //    ZoomCamera(scroll,ZoomSpeedMouse);
    //}

    //void PanCamera(Vector3 newPanPosition) {
    //    // Determine how much to move the camera
    //    Vector3 offset = cam.ScreenToViewportPoint(lastPanPosition - newPanPosition);
    //    Vector3 move = new Vector3(offset.x * PanSpeed,0,offset.y * PanSpeed);

    //    // Perform the movement
    //    transform.Translate(move,Space.World);

    //    // Ensure the camera remains within bounds.
    //    Vector3 pos = transform.position;
    //    pos.x = Mathf.Clamp(transform.position.x,BoundsX[0],BoundsX[1]);
    //    pos.z = Mathf.Clamp(transform.position.z,BoundsZ[0],BoundsZ[1]);
    //    transform.position = pos;


    //    // Cache the position
    //    lastPanPosition = newPanPosition;
    //}

    //void ZoomCamera(float offset,float speed) {
    //    if(offset == 0) {
    //        return;
    //    }

    //    cam.fieldOfView = Mathf.Clamp(cam.fieldOfView - (offset * speed),ZoomBounds[0],ZoomBounds[1]);
    //}
}