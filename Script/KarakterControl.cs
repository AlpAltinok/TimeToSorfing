using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterControl : MonoBehaviour
{
    private float horizontalValue;
    public float HorizontalValue
    {
        get { return horizontalValue; }
    }

  
    void Update()
    {
        HandleHorizontalInput();   
    }


    private void HandleHorizontalInput() {
        if (Input.GetMouseButton(0))
        {
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalValue = 0;
        }
    
    }

}
