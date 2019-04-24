using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasterEgg : MonoBehaviour
{



    public Animator Crocodile;
    public Animator Safari;
    public Animator Pig;

    public GameObject Easterino;

    float touchDuration;
    Touch touch;



    public bool crocIsPlaying;
    public bool safariIsPlaying;
    public bool pigIsPlaying;
    public bool lastplayed;

    // Use this for initialization
    void Start()
    {



        Crocodile.enabled = false;
        Safari.enabled = false;
        Pig.enabled = false;

        crocIsPlaying = false;
        safariIsPlaying = false;
        pigIsPlaying = false;

        lastplayed = false;
        Easterino.SetActive(false);



    }




    public void ItsGonaStart()
    {

        if (crocIsPlaying == false)
        {
            Crocodile.enabled = true;
            crocIsPlaying = true;
        }
        else if (crocIsPlaying && pigIsPlaying == false)
        {
            Pig.enabled = true;
            pigIsPlaying = true;
        }
        else if (pigIsPlaying && safariIsPlaying == false)
        {
            safariIsPlaying = true;
            Safari.enabled = true;
        }
        else if (pigIsPlaying && safariIsPlaying && crocIsPlaying)
        {
            lastplayed = true;
            Easterino.SetActive(true);

            StartCoroutine("Stop");

        }
    }


        IEnumerator Stop()
        {
            yield return new WaitForSeconds(4f);
            Crocodile.enabled = false;
            Pig.enabled = false;
            Safari.enabled = false;

            safariIsPlaying = false;
            pigIsPlaying = false;
            crocIsPlaying = false;

        SceneManager.LoadScene("UI-Menu");

        }



}

