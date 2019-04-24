using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextStep : MonoBehaviour {

    // I SHOULDVE USED LIST INSTEAD OF ARRAYS BUT IT WAS TOO LATE UNTIL I REMEMBERED ABOUT LIST
    // THIS ISNT BAD IDEA BUT ITS PRETTY INFLEXIBLE.
    // IF YOU WANA CREATE A SLIDER THAT YOU CAN INTERACT TO SHIFT THE VALUE AKA GO TO DIFFERENT STEPS BY SLIDING THE SLIDER. USE A LIST INSTEAD, THAT MIGHT BE ALOT BETTER
    
        // THIS IS TO CHANGE THE STEPS BY PRESSING THE NEXT OR PREVIOUS BUTTON ON THE PROJECT SCENES - JOSEPH

   
        // COMPLETED MODEL = THE FINAL PRODUCT AFTER FINISH BUILDING
    public GameObject completedModel;

    // THE BUTTON TO SHOW ALL THE PARTS NEEDED FOR THE PROJECTS. SOME PROJECTS HAVE THIS SOME DONT. MOSTLY ALL WORKSHOPS HAS THIS
    public GameObject fullPartsButton;

    // THE PICTURE FOR ALL OF THE PARTS
    public GameObject allParts;

    // IT ISNT REALLY RETURN TO MENU ITS MORE LIKE RETURN TO PREVIOUS SCENE. AND ITS A BUTTON
    public GameObject returnToMenu;

    // THIS EXPLAINS ITSELF.
    public GameObject nextStepButton;
    public GameObject previousStepButton;

    // TEXT TO SHOW THE NAME OF THE STEP YOU ARE ON. THIS GETS DISPLAYED IN THE APP
    public Text text;

    // THIS IS THE BOOLEAN TO CHECK IF THE BUTTON IS PRESSED.
    public static bool nextStep;
    public static bool previousStep;

    // THE CURRENT STEP YOU ARE ON - THIS IS FOR THE STEPSBAR SCRIPT
    public float currentSteps;

    // THIS IS FOR THE STEPS
    public GameObject[] parts;

    // THIS BAR BASICALLY IS THE STEPS BAR
    public Slider bar;

    // THIS IS THE NAME OF THE CURRENT GAME OBJECT THAT IT IS DISPLAYING
    new string name;

    // FOR STEPS BAR AS WELL.
    public static bool resetIMG = false;
    public Sprite happyLego;
    public Sprite walkingLego;

    // Use this for initialization
    void Start () {

        fullPartsButton = GameObject.FindWithTag("c_fullparts");
        returnToMenu = GameObject.FindWithTag("c_menu");
        nextStepButton = GameObject.FindWithTag("c_nextstep");
        previousStepButton = GameObject.FindWithTag("c_previousstep");
        text = GameObject.FindWithTag("c_text").GetComponent<Text>();
        bar = GameObject.FindWithTag("StepsSlider").GetComponent<Slider>();

        returnToMenu.SetActive(true);

        nextStep = false;
        previousStep = false;
        
        
    }

    // Update is called once per frame
    void Update() {



        // right and up arrow to move to the next step
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow) || nextStep)
        {
            // using array and for loop to check for current index and open next index and close current index then break loop
            for (var i = 0; i < parts.Length; i++)
            {
                if (parts[i].activeInHierarchy && i < parts.Length - 1)
                {
                    parts[i].SetActive(false);
                    parts[i + 1].SetActive(true);
                    print(parts[i + 1] + " is active");
                    nextStep = false;
                    //currentSteps += 1;

                    break;
                }
            }
        }

        // left and down arrow to move to the previous step
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || previousStep)
        {
            // using array and for loop to check for current index and open previous index and close current index then break loop
            for (var i = 0; i < parts.Length; i++)
            {
                if (parts[i].activeInHierarchy && i > 0)
                {
                    parts[i].SetActive(false);
                    parts[i - 1].SetActive(true);
                    //print(parts[i - 1] + " is active");
                    previousStep = false;

                    //currentSteps -= 1;

                    break;
                }
            }
        }



        // to enable the buttons and text msges
        for (var i = 0; i < parts.Length; i++)
        {
            name = parts[i].name;

            StepsBar.max_Steps = parts.Length;

            currentSteps = i;

            if (parts[i].activeInHierarchy && (i == 0))
            {
                previousStepButton.SetActive(false);
            } else
            {
                previousStepButton.SetActive(true);
            }

            if ((parts[i].activeInHierarchy && (i == parts.Length - 1) ) || allParts.activeInHierarchy)
            {
                bar.image.sprite = happyLego;
                nextStepButton.SetActive(false);
            } else
            {
                nextStepButton.SetActive(true);
                bar.image.sprite = walkingLego;
            }

            //enable the return to menu button if current step/element/index is at 0 or final step
            if (parts[i].activeInHierarchy && (i == parts.Length - 1 || i == 0))
            {
                returnToMenu.SetActive(true);


                break;
                
            } else
            //disable the return to menu button if current step/element/index is not at first or final step
            if (parts[i].activeInHierarchy && (i != parts.Length - 1 || i != 0))
            {
                previousStepButton.SetActive(true);
                returnToMenu.SetActive(false);
                break;
            }

        }

        bar.value = currentSteps;


    }

    // if first index is active, you can enable to see the whole parts needed vice versa
    private void FixedUpdate()
    {
        if (completedModel.activeInHierarchy || allParts.activeInHierarchy)
        {
            fullPartsButton.SetActive(true);
        } else
        {
            fullPartsButton.SetActive(false);
        }

        if (!allParts.activeInHierarchy)
        {
            text.text = name;

        } else
        {
            text.text = " ";
        }

    }

    //public void ChangeHappySprite() {
    //    if(parts.Length == -1) {
    //        bar.image.sprite = happyLego;
    //    }
    //}


    // if button is on full parts 
    public void FullPartsList()
    {
        if (!allParts.activeInHierarchy)
        {
            allParts.SetActive(true);
            nextStepButton.SetActive(false);
            previousStepButton.SetActive(false);

        } else
        {
            allParts.SetActive(false);
            nextStepButton.SetActive(true);
            previousStepButton.SetActive(true);
        }

    }


    // basically next step
    public void B_nextStep()
    {
        nextStep = true;
        resetIMG = true;
    }

    // basically previous step
    public void B_previousStep()
    {
        previousStep = true;
        resetIMG = true;
    }


}