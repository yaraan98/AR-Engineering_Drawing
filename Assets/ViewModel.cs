using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewModel : MonoBehaviour
{
    public GameObject m1;
    public GameObject ImageTarget;
    // Start is called before the first frame update
    void Start()
    {
        GameObject NewModel = Instantiate(m1, ImageTarget.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
