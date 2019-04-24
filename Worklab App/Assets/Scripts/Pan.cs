using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour {

    // this is pretty simple and straight forward one of the easier ones to work with. - i didnt code this but i edited it - Joseph

    public Camera thisCamera;
    float speed = 0.005F;

    private static readonly float[] BoundsX = new float[] { -1f,1f };
    private static readonly float[] BoundsY = new float[] { -1f,1f };

    private static readonly float[] BoundsinX = new float[] { -4f,4f };
    private static readonly float[] BoundsinY = new float[] { -2.5f,2.5f };
    //private static readonly float[] ZoomBounds = new float[] { 10f,85f };

    private void Start() {
        thisCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }

    void Update() {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-touchDeltaPosition.x * speed,-touchDeltaPosition.y * speed,0);
        } else if(NextStep.resetIMG) {
            transform.position = new Vector3(0,0,-5f);
            thisCamera.fieldOfView = 75f;
            NextStep.resetIMG = false;
        }

        if(thisCamera.fieldOfView <= 60f) {
            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(transform.position.x,BoundsinX[0],BoundsinX[1]);
            pos.y = Mathf.Clamp(transform.position.y,BoundsinY[0],BoundsinY[1]);
            transform.position = pos;
        } else {
            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(transform.position.x,BoundsX[0],BoundsX[1]);
            pos.y = Mathf.Clamp(transform.position.y,BoundsY[0],BoundsY[1]);

            transform.position = pos;
        }

    }
}
