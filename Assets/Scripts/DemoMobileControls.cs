using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoMobileControls : MonoBehaviour
{
    public DayNightController controller;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var pos = Input.mousePosition;

            if(pos.x > Screen.width * 0.5f)
            { 
                controller.CurrentTimeOfDay += 0.05f;
            }
            else
            { 
                controller.CurrentTimeOfDay -= 0.05f;
            }
        }
    }
}
