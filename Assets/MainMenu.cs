using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public static string ModelName;
    public static string NumberOfQuestions;

    //Method to go to Scene of Viewing Models 
    public void GoToScanModelMenu()
    {
        SceneManager.LoadScene("ScanModel Menu");
    }

    //Method to go to TestYourself Menu Scene
    public void GoToTestYourselfMenu()
    {
        SceneManager.LoadScene("TestYourself Menu");
    }

    public void GoToInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    //Method Used to direct to viewing model 
    public void ScanModels()
    {
        ModelName = EventSystem.current.currentSelectedGameObject.name; //used in ChangeModels.cs
        Debug.Log("MM " + EventSystem.current.currentSelectedGameObject.name);
        Debug.Log("ModelName in MainMenu " + ModelName);
        SceneManager.LoadScene("ViewModel"); //go to AR Camera view of models
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }


    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //Method to Quit
    public void QuitGame()
    {
        Debug.Log("QUIT!!!");
        
            Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //Method to choose easy, medium , hard
    public void ChoosingNumberOfQuestions()
    {
       
        NumberOfQuestions = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        SceneManager.LoadScene(EventSystem.current.currentSelectedGameObject.name);
    }
   
    
}
