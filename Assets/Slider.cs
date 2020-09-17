using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Slider : MonoBehaviour
{
    GameObject model;
    // Start is called before the first frame update
    public void OnValue(float value)
    {
        //change scale of model
        model = GameObject.Find("d2");
        Debug.Log("New Value" + value);
        Debug.Log("here");
        Debug.Log(model.name);
        Debug.Log(model.transform.position);
        Debug.Log(model.transform.localScale);
    }
}
