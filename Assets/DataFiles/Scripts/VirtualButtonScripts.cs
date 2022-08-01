using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScripts : MonoBehaviour
{
    public GameObject cubeGO, sphereGO;
    VirtualButtonBehaviour vrb;
    
    void Start()
    {
        cubeGO.SetActive(false);
        sphereGO.SetActive(true);

        vrb = GetComponentInChildren<VirtualButtonBehaviour>();

        vrb.RegisterOnButtonPressed(onButtonPressed);
        vrb.RegisterOnButtonReleased(onButtonReleased);
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeGO.SetActive(true);
        sphereGO.SetActive(false);
        Debug.Log("Button Pressed");
    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeGO.SetActive(false);
        sphereGO.SetActive(true);
        Debug.Log("Button Released");
    }
}
