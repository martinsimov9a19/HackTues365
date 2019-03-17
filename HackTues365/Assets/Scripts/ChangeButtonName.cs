using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonName : MonoBehaviour
{
    public Text text;
    private int index = 0;

    public void ChangeButtonText() {
        if (index == 0)
        {
            text.text = "WINDOWED";
            index = 1;
        }
        else {
            text.text = "FULL SCREEN";
            index = 0;
        }
    
       
    }

}
