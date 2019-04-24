using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour {

    Scene m_Scene;

    string sceneName;

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }


    /*  LOOK HERE AND READ THIS - change every time for the next batch of interns for any problems that you dont have enough time to work on.
     * 
     * i apologize if the UI naming is confusing but it was for easy access and remembering
     * Scenes under UI scenes would have UI infront of them.
     * 
     * example 
     * UI-PS-SCH-XJR 
     * this means under Ui, Project selection, School, Xtreme Junior Robotics.
     * 
     * I tried to make all the naming conventions as understandable as possible in the scenes and scripts.
     * some of it might not be very understandable and u can change it so long as you know what the code is doing and how to back track if you forgot.
     * 
     * Those that you dont understand isnt done by me :D
     * For future interns, whats up, im Joseph from Singapore Polytechnic, year 3 batch 2. 2018. If yall got any questions about the codes or enquire abt anything drop me a dm so long as i dont change my link.
     * Instagram : https://www.instagram.com/josephloj/  
     * Facebook : https://www.facebook.com/josephlimchengzhi
     * 
     * 
     * Do write down your name, Year and Batch to keep the tradition going
     * 
     *  SP DGDD - Joseph, Year 3 Batch 2, 2018
     *  
     * 
     *\



    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------
    //---REMEBER TO UPDATE FOR ANY FUTURE PROJECTS/SCENES----------------------------------------------------




    /*  UI-MENU                     
     *  
     *  UI-PS                       
     *  
     *  UI-PS-KC                    
     *  
     *  UI-PS-KC-MJ                 
     *  UI-PS-KC-MJ-FT              
     *  UI-PS-KC-MJ-ST    
     *  UI-PS-KC-MJ-TT 
     *  
     *  UI-PS-KC-RA                 
     *  UI-PS-KC-RA-LVL PARTY       
     *  UI-PS-KC-RA-LVL SPORTS       
     *  UI-PS-KC-RA-LVL PROPELLERS     
     *  UI-PS-KC-RA-LVL SAFARI  
     *  UI-PS-KC-RA-LVL TRUCK      
     *  UI-PS-KC-RA-LVL OCEANIC       
     *  UI-PS-KC-RA-LVL RAINFOREST     
     *  UI-PS-KC-RA-LVL TECH  
     *  
     *  UI-PS-SCH     
     *  
     *  UI-PS-SCH-AE
     *  UI-PS-SCH-AE 1
     *  UI-PS-SCH-AE 2
     *  UI-PS-SCH-AE 3
     *  UI-PS-SCH-AE 4
     *  UI-PS-SCH-AE 5
     *  
     *  UI-PS-SCH-JR                
     *  UI-PS-SCH-XJR 
     *  
     *  UI-PS-SCH-NXT
     *  UI-PS-SCH-NXT 1.0
     *  UI-PS-SCH-NXT 2.0
     *  UI-PS-SCH-NXT-MULTI
     *  
     *  UI-PS-WS                    
     *  
     *  UI-PS-WS-JE                 
     *  UI-PS-WS-JE 1               
     *  UI-PS-WS-JE 2               
     *  UI-PS-WS-JE 3               
     *  
     *  UI-PS-WS-ME                 
     *  
     *  UI-PS-WS-SE 
     *  
     *  UI-PS-WS-SE 1               
     *  UI-PS-WS-SE 2               
     *  UI-PS-WS-SE 3               
     *  UI-PS-WS-SE 4               
     */



    //-------------- BACK TO PREVIOUS SCENES--------------------

    /*https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager-activeSceneChanged.html
    // That URL is for the future interns to reference and streamline the codes, at the time i didn't thought of using this so i went the troublesome way.
    it would be more efficient to use this method as so that you dont need to write down so many lines of code.

        player pref save the previous scene under a string then get the string when you click return.
        Refer to the link or you can refer to this two Scripts i have inside this project. Login menu and ResetPass
    */

    private void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
    }



    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------

    //----UI SCREENS---------Menu---------------------------------------------------



    // Go back to main menu = start menu
    public void OnMenu()
    {

            SceneManager.LoadScene("UI-Menu");
        
    }


    //----UI SCREENS---------PROJECTSELECTION---------------------------------------

    // go to project selection menu
    public void OnPS()
    {
        SceneManager.LoadScene("UI-PS");
    }


    //----UI SCREENS---------KINDYCAMP----------------------------------------------
    //----UI SCREENS---------KINDYCAMP----------------------------------------------
    //----UI SCREENS---------KINDYCAMP

    // to kindy camp
    public void OnKC()
    {
        SceneManager.LoadScene("UI-PS-KC");
    }

    //---------------------------------------------------------------------------------

    // to mycamp junior
    public void OnMJ()
    {
        SceneManager.LoadScene("UI-PS-KC-MJ");
    }

    // to mycamp junior first time
    public void OnFT()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-MJ-FT");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-MJ-FT");

        }
    }

    // to mycamp junior second time
    public void OnST()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-MJ-ST");
        } 
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-MJ-ST");

        }

    }

    // to mycamp junior third time
    public void OnTT()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-MJ-TT");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-MJ-TT");

        }
    }

    //------------------------------------------------------------------------------------

    // to robocamp apprentice
    public void OnRA()
    {
        SceneManager.LoadScene("UI-PS-KC-RA");
    }

    // to robocamp apprentice party with animals
    public void OnPARTY()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL PARTY");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL PARTY");

        }
    }

    // to robocamp apprentice sports savvy
    public void OnSPORTS()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL SPORTS");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL SPORTS");

        }
    }

    // to robocamp apprentice propellers
    public void OnPROPELLERS()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL PROPELLERS");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL PROPELLERS");

        }
    }

    // to robocamp apprentice wild safari
    public void OnSAFARI()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL SAFARI");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL SAFARI");

        }
    }

    // to robocamp apprentice monster truck
    public void OnTRUCK()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL TRUCK");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL TRUCK");

        }
    }

    // to robocamp apprentice oceanic adventures
    public void OnOCEANIC()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL OCEANIC");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL OCEANIC");

        }
    }

    // to robocamp apprentice rainforest adventures
    public void OnRAINFOREST()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL RAINFOREST");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL RAINFOREST");

        }
    }

    // to robocamp apprentice tech machines
    public void OnTECH()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL TECH");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-KC-RA-LVL TECH");

        }
    }

    //----UI SCREENS---------SCHOOL-------------------------------------------------
    //----UI SCREENS---------SCHOOL-------------------------------------------------
    //----UI SCREENS---------SCHOOL-------------------------------------------------


    // to school projects
    public void OnSCH()
    {
        SceneManager.LoadScene("UI-PS-SCH");
    }

    //------------------------------------------------------

    // to school projects apprentice engineering
    public void OnAE()
    {
        SceneManager.LoadScene("UI-PS-SCH-AE");
    }

    // to school projects apprentice engineering 1
    public void OnAE1()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-AE 1");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-SCH-AE 1");

        }
    }

    // to school projects apprentice engineering 2
    public void OnAE2()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-AE 2");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-SCH-AE 2");

        }
    }

    // to school projects apprentice engineering 3
    public void OnAE3()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-AE 3");
        }
        else if (sceneName.Contains("UI"))
        {

            SceneManager.LoadScene("UI-PS-SCH-AE 3");
        }
    }

    // to school projects apprentice engineering 4
    public void OnAE4()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-AE 4");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-SCH-AE 4");

        }
    }

    // to school projects apprentice engineering 5
    public void OnAE5()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-AE 5");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-SCH-AE 5");

        }
    }



    //----------------------------------------------------------------

    // to school projects junior robotics
    public void OnJR()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-JR");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-SCH-JR");

        }
    }

    // to school projects xtreme junior robotics
    public void OnXJR()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-XJR");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-SCH-XJR");

        }
    }

    // to school projects nxt
    public void OnNXT()
    {
        SceneManager.LoadScene("UI-PS-SCH-NXT");
    }

    // to school projects nxt 1.0
    public void OnNXT1()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-NXT 1.0");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-SCH-NXT 1.0");

        }
    }

    // to school projects nxt 2.0
    public void OnNXT2()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-NXT 2.0");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-SCH-NXT 2.0");

        }
    }

    // to school projects nxt 2.0 multibot scene
    public void OnMultiBot()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-SCH-NXT-MULTI");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-SCH-NXT-MULTI");

        }
    }


    //----UI SCREENS--------WORKSHOP------------------------------------------------
    //----UI SCREENS--------WORKSHOP------------------------------------------------
    //----UI SCREENS--------WORKSHOP------------------------------------------------


    // to workshop
    public void OnWS()
    {
        SceneManager.LoadScene("UI-PS-WS");
    }

    //-------------------------------------------------------------------

    // to workshop junior engineering 
    public void OnJE()
    {
        SceneManager.LoadScene("UI-PS-WS-JE");
    }

    // to workshop junior engineering 1
    public void OnJE1()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-WS-JE 1");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-WS-JE 1");

        }
    }

    // to workshop junior engineering 2
    public void OnJE2()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-WS-JE 2");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-WS-JE 2");

        }
    }

    // to workshop junior engineering 3
    public void OnJE3 ()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-WS-JE 3");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-WS-JE 3");

        }
    }

    //--------------------------------------------------------------------------------

    // to workshop senior engineering
    public void OnSE()
    {
        SceneManager.LoadScene("UI-PS-WS-SE");
    }

    // to workshop senior engineering 1
    public void OnSE1()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-WS-SE 1");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-WS-SE 1");

        }
    }

    // to workshop senior engineering 2
    public void OnSE2()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-WS-SE 2");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-WS-SE 2");

        }
    }

    // to workshop senior engineering 3
    public void OnSE3()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-WS-SE 3");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-WS-SE 3");

        }
    }

    // to workshop senior engineering 4
    public void OnSE4()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-WS-SE 4");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-WS-SE 4");

        }
    }

    //--------------------------------------------------------------------------------

    // to workshop master engineering
    public void OnME()
    {
        if (!sceneName.Contains("UI") && TapPassword.doubleTap)
        {
            SceneManager.LoadScene("UI-PS-WS-ME");
        }
        else if (sceneName.Contains("UI"))
        {
            SceneManager.LoadScene("UI-PS-WS-ME");

        }
    }

}
