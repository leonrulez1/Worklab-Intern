using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ResetPass : MonoBehaviour {


    // SIMPLE OFFLINE METHOD OF SAVING PASSWORD/ RESETING PASSWORD - JOSEPH


    public InputField newPassword;

    public InputField oldPassword;

    string password;

    public Button btnAccept;


    // the gameobject(panel) that will contain the words password has been reset successfully
    public GameObject resetText;


    private void Start()
    {
        //Sadly unity can't detect inputfield or button or gameobject wtf?? using find with tag. i tried multiple ways to bypass this but to no avail, probably cause im shit

        //newPassword = GameObject.FindWithTag("newPassword").GetComponent<InputField>();
        //oldPassword = GameObject.Find("Input_OldPassword").GetComponent<InputField>();
        //btnAccept = GameObject.FindWithTag("btnAccept").GetComponent<Button>();
        //resetText = GameObject.FindWithTag("resetText").GetComponent<GameObject>();


        resetText.SetActive(false);

        Button newbtn = btnAccept.GetComponent<Button>();

        newbtn.onClick.AddListener(Save);


    }

    void Save()
    {
        password = PlayerPrefs.GetString("Password");

        if (oldPassword.text != password || newPassword.text == "")
        {
            print("fail");
            oldPassword.text = "";
            newPassword.text = "";
            Vibration.Vibrate(500);
        }
        else
        {
            print("saved");

            PlayerPrefs.SetString("Password", newPassword.text);
            PlayerPrefs.Save(); // Writes all modified preferences to disk

            resetText.SetActive(true);

        }
    }

}