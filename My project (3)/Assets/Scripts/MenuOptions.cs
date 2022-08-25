using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOptions : MonoBehaviour
{
    
    public void onButtonStart()
    {
        Application.LoadLevel("SampleScene");
    }

    public void onButtonExit()
    {
        Application.Quit();
    }
}
