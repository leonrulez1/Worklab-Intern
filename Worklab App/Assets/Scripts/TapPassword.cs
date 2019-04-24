using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class TapPassword : MonoBehaviour
{

    float touchDuration;
    Touch touch;

    public float doubleTapTimer;

    public static bool doubleTap;

    

    private void Start()
    {
        doubleTap = false;

        doubleTapTimer = 1f;
    }

    void Update()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        if (Input.touchCount > 0)
        { //if there is any touch
            touchDuration += Time.deltaTime;
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended && touchDuration < 0.3f)
            { //making sure it only check the touch once && it was a short touch/tap and not a dragging.
                StartCoroutine("singleOrDouble");
            }
        }
        else
        {
            touchDuration = 0.0f;
        }

        if (doubleTap)
        {

            doubleTapTimer -= Time.deltaTime;
            if(doubleTapTimer < 0f)
            {
                doubleTap = false;
                print("Double Tap Duration is Over, Returning False");

                doubleTapTimer = 1f;

            }
        }

    }



    IEnumerator singleOrDouble()
    {
        yield return new WaitForSeconds(0.5f);
        if (touch.tapCount == 1)
        {
            Debug.Log("SingleTap");

        }
        else if (touch.tapCount == 2)
        {
            doubleTap = true;
            //this coroutine has been called twice. We should stop the next one here otherwise we get two double tap
            StopCoroutine("singleOrDouble");
            touchDuration = 0.0f;

            Debug.Log("DoubleTap");
        }

        print("Did it double Tap: " + doubleTap);
    }
}

