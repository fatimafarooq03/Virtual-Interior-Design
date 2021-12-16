using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRSceneScript : MonoBehaviour
{
    public GameObject camObject;
    // Start is called before the first frame update
    void Start()
    {

        float camX = PlayerPrefs.GetFloat("CAMX");
        float camY = PlayerPrefs.GetFloat("CAMY");
        float camZ = PlayerPrefs.GetFloat("CAMZ");
        camObject.transform.position = new Vector3(camX, camY, camZ);//StaticVariables.camPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            goBackToMainMenu();
        }
    }

    void goBackToMainMenu()
    {
        SceneManager.LoadScene("main menu scene");
    }
}
