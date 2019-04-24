using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class LoginMenu : MonoBehaviour {

    // FOR PASSWORD TO LOGIN


    public InputField currentPassword;

    string password;

    public Button btnlogin;

    public static string originalPassword;

    string masterPassword;


    void Start()
    {


        //Sadly unity can't detect inputfield or the button using findwithtag. i tried multiple ways to bypass this but to no avail, probably cause im shit

        //currentPassword = GameObject.FindWithTag("currentPassword").GetComponent<InputField>();
        //btnlogin = GameObject.FindWithTag("btnLogin").GetComponent<Button>();

        Button loginbtn = btnlogin.GetComponent<Button>();

        loginbtn.onClick.AddListener(Load);

        if (PlayerPrefs.HasKey("Password"))
        {
            print("has password");
        } else
        {
            print("no password");
        }

        originalPassword = "betterminds";


    }



    void Load()
    {


        if (PlayerPrefs.HasKey("Password"))
        {

            password = PlayerPrefs.GetString("Password");

            print(password);

            if (currentPassword.text == password || currentPassword.text == originalPassword)
            {
                print("success login");
                SceneManager.LoadScene(1);
            }
            else
            {
                Vibration.Vibrate(500);
                print("fail");
                currentPassword.text = "";

            }


        }
        else
        {
            print("no password");

            if ( currentPassword.text == "")
            {
                SceneManager.LoadScene(1);
            }

        }
    }

}
