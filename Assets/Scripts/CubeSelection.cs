using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelection : MonoBehaviour
{

    public Texture2D blue, red;

    public void TriggerIn()
    {
        GetComponent<Renderer>().material.mainTexture = red;
    }


    public void TriggerOut()
    {
        GetComponent<Renderer>().material.mainTexture = blue;
    }


}