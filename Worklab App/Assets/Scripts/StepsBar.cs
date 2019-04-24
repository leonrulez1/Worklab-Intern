using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepsBar : MonoBehaviour {

    // A SIMPLE WAY TO MAKE THE SLIDER TO ESTIMATE WHAT STEP YOU ARE ON. AND HOW LONG MORE TO FINISH. - JOSEPH


    public static float max_Steps;
    ////public float steps;
    public Slider bar;


    //NextStep nxtstepScript;

    // Use this for initialization
    void Start() {

        bar = GameObject.FindWithTag("StepsSlider").GetComponent<Slider>();

        //bar.maxValue = max_Steps;

        //nxtstepScript = GetComponent<NextStep>();

        //steps = nxtstepScript.currentSteps;
        //bar.value = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //float calc_Steps = steps / max_Steps;
        //SetStepsBar(calc_Steps);    

	}

    private void FixedUpdate() {
        bar.maxValue = max_Steps;
    }
        //}

        //public void SetStepsBar(float mySteps) {
        //    bar.value = mySteps;
        //}

    }
