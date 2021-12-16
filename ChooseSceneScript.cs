using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class ChooseSceneScript : MonoBehaviour
{
    //when test input on `vr you change this line
    public Button room1Button, room2Button, room3Button, room4Button, exitbutton;
    // Start is called before the first frame update
    void Start()
    {
        //when test iput on `vr you change these 4 lines
        room1Button.onClick.AddListener(goToRoom1);
        room2Button.onClick.AddListener(goToRoom2);
        room3Button.onClick.AddListener(goToRoom3);
        room4Button.onClick.AddListener(goToRoom4);
        exitbutton.onClick.AddListener(exitgamefn); 


    }

    void goToRoom1()
    {
        gotoRoom(new Vector3(-46.5f, 0.3f, 3.1f), false);
    }

    void goToRoom2()
    {
        gotoRoom(new Vector3(-36.3f, 0.3f, 3.1f), false);
    }

    void goToRoom3()
    {
        gotoRoom(new Vector3(-26.6f, 0.3f, 2.9f), false);
    }

    void goToRoom4()
    {
        gotoRoom(new Vector3(-14.1f, 0.3f, 2.9f), true);
    }

    void gotoRoom(Vector3 camPos, bool showButtons)
    {
        PlayerPrefs.SetFloat("CAMX", camPos.x);
        PlayerPrefs.SetFloat("CAMY", camPos.y);
        PlayerPrefs.SetFloat("CAMZ", camPos.z);
        StaticVariables.camPosition = camPos;
        StaticVariables.showButtons = showButtons;
        SceneManager.LoadScene("roomsScene");
    }

    void exitgamefn()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
