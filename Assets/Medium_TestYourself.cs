using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Medium_TestYourself : MonoBehaviour
{
    public GameObject panel1, panel2, panel3, panel4, panel5,panel6,panel7; //panels
    public GameObject m1, m2, m3, m4, m5,m6,m7; //models
    public GameObject ImageTarget;
    public static GameObject RequiredPanel; //make it the option panel
    public static GameObject RequiredModel; //make it the option model
    // public static int ModelName;
    public AudioSource WrongSFX;
    public AudioSource RightSFX;
    public static int NumOfQues;
    public static int CurrentQuestion;
    public static int CurrentQuestionIndex;
    public static GameObject NewModel;
    public static int[] Questions; //Array of questions Order


    void Start()
    {

        //CurrentQuestion = 1;
        DetermineNumberOfQuestions();
        
        //WrongSFX= GetComponent<AudioSource>();
        //RightSFX=GetComponent<AudioSource>();
        //NumOfQues = Int32.Parse(MainMenu.NumberOfQuestions.ToCharArray()[0]+""); //either 3,5,or 10
        //Debug.Log("NumOfQues= " + NumOfQues);
        //ModelName = '1';//1st model for 1st Q
        //Debug.Log("Start , MOdelNAme= " + ModelName);
        //SwitchOnModel();
    }

    public void DetermineNumberOfQuestions()
    {
        Debug.Log("IN DetermineNumberOfQuestions");
        NumOfQues = Int32.Parse(MainMenu.NumberOfQuestions.ToCharArray()[0] + ""); //either 3,5,or 10
        Debug.Log("NumOfQues= " + NumOfQues);

        RandomQuestions(NumOfQues); //sends 3,5 or 10

        CurrentQuestionIndex = 0; //to point at array
        SwitchOnModelTrial();
    }

    public void SwitchOnModelTrial()
    {
        CurrentQuestion = Questions[CurrentQuestionIndex];
        switch (CurrentQuestion)
        {
            case 1: RequiredPanel = panel1; RequiredModel = m1; break;
            case 2: RequiredPanel = panel2; RequiredModel = m2; break;
            case 3: RequiredPanel = panel3; RequiredModel = m3; break;
            case 4: RequiredPanel = panel4; RequiredModel = m4; break;
            case 5: RequiredPanel = panel5; RequiredModel = m5; break;
            case 6: RequiredPanel = panel6; RequiredModel = m6; break;
            case 7: RequiredPanel = panel7; RequiredModel = m7; break;

        }
        RequiredPanel.SetActive(true);
        NewModel = Instantiate(RequiredModel, ImageTarget.transform); //Created the required model with pos according to ImageTarget
                                                                      // RequiredModel.SetActive(true);
    }

    //public void SwitchOnModel()
    //{
    //    switch (CurrentQuestion)
    //    {
    //        case 1: RequiredModel = m1; break;
    //        case 2: RequiredModel = m2; break;
    //        case 3: RequiredModel = m3; break;
    //    }

    //    NewModel = Instantiate(RequiredModel, ImageTarget.transform); //Created the required model with pos according to ImageTarget
    //    Vector3 scaleChange = new Vector3(-0.0135496f, -0.0135496f, -0.0135496f);//Scale it down
    //    Vector2 transfUp = new Vector3(0f, 0.2f, 0.0f); //To make it on top of plane
    //    NewModel.transform.Rotate(90, 0, 180);
    //    NewModel.transform.localScale = scaleChange;
    //    NewModel.transform.localPosition = transfUp;


    //}
    public void WrongAnswer()
    {
        //WrongSFX.Play();
        Debug.Log("Wrong Answer");
        WrongSFX.Play();
    }
    public void RightAnswer()
    {
        RequiredPanel.SetActive(false);
        // RequiredModel.SetActive(false);
        Destroy(NewModel);
        Debug.Log(RequiredPanel.name);
        //RightSFX.Play();
        Debug.Log("Right Answer");
        RightSFX.Play();
        CurrentQuestionIndex++;

        if (CurrentQuestionIndex < NumOfQues)  //Not finished yet   

            SwitchOnModelTrial();

        else
        {
            Debug.Log("End of Questions!");
            SceneManager.LoadScene("TestYourself Menu"); //go to AR Camera view of models
        }

    }

    public static void PrintArray(int[] arr)
    {
        String str = "[";
        for (int i = 0; i < arr.Length; i++)
        {
            str = str + arr[i] + ", ";
        }
        str += "]";
        // Console.WriteLine("ARRAY + " + str);
        Debug.Log("ARRAY + " + str);
    }
    public void RandomQuestions(int Arrlength)
    {
        int j = 0;
        int i = 0;
        Questions = new int[Arrlength]; //to store in it the questions order
        int len = Questions.Length;
        while (i < len)
        {
            Questions[i] = UnityEngine.Random.Range(1, len + 3);

            while (j < i)
            {
                if (Questions[i] == Questions[j])
                {
                    i--;
                    break;
                }
                else j++;


            }
            i++;
            j = 0;
        }
        PrintArray(Questions);
    }
}
