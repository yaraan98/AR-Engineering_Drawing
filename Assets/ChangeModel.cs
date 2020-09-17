using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOTE:: When ADDIng Models don't forget to change their name to their respect. needed model m1 mx etc..
public class ChangeModel : MonoBehaviour
{
    public GameObject m1,m2,m3,m4,m5,m6; //models
    public GameObject ImageTarget;
    public static GameObject RequiredModel; //model to be displayed
    public static char ModelName; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("In start of change model");
        Debug.Log("button name = "+ MainMenu.ModelName.ToCharArray()[MainMenu.ModelName.Length - 1]);
        ModelName = MainMenu.ModelName.ToCharArray()[MainMenu.ModelName.Length - 1]; //get name of button pressed to get which model to display
        Debug.Log("IN CHANGEMODEL");
        Debug.Log("ModelName " + ModelName);
        SwitchOnModel();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SwitchOnModel()
    {
        switch (ModelName)
        {
            case '1': RequiredModel = m1; break;
            case '2': RequiredModel = m2; break;
            case '3':RequiredModel = m3;break;
            case '4': RequiredModel = m4; break;
            case '5': RequiredModel = m5; break;
            case '6': RequiredModel = m6; break;
        }

        GameObject NewModel = Instantiate(RequiredModel, ImageTarget.transform);
        //Vector3 scaleChange = new Vector3(-0.0135496f, -0.0135496f, -0.0135496f);
       // Vector2 transfUp = new Vector3(0f, 0.2f, 0.0f);
       // NewModel.transform.Rotate(90, 0, 0); 
       // NewModel.transform.localScale = scaleChange;
        //NewModel.transform.localPosition = transfUp;

    }
 
 
}
