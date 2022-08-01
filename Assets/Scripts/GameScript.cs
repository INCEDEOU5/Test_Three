using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public TextMeshProUGUI counterGUI;
    private int counter = 0;
    public Light lighting;

    public TextMeshProUGUI buttonGUI;
    public AudioSource buttonSFX;

    public string nextLevelName; 

    // Start is called before the first frame update
    void Start()
    {
        counterGUI.text = "Counter: " + counter;
        buttonGUI.text = "Turn Off";
        //Update the counterGUI text to display current count
        //Update the buttonGUI to say "Turn Off"
    }


    public void TurnLightOnOff()
    {
        if (lighting.enabled)
        {
            lighting.enabled = false;
            //Update the buttonGUI to say "Turn On" 
            buttonGUI.text = "Turn On";
        }
        else
        {
            lighting.enabled = true;
            counter++;
            lighting.color = new Color(Random.Range(0,0.99f), Random.Range(0, 0.99f), Random.Range(0, 0.99f), 1);
            counterGUI.text = "Counter: " + counter;
            buttonGUI.text = "Turn Off";
            //Update the counterGUI text to display current count
            //Update the buttonGUI to say "Turn Off"
        }
        buttonSFX.Play();
    }

    public void goToNextLevel()
    {
        buttonSFX.Play();
        SceneManager.LoadScene(nextLevelName);
        //Use Scene Manager and the nextLevelName variable to Load into MainMenu
        //Use the buttonSFX to play when this function executes
    }
}
