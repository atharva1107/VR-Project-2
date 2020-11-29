using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExposureMeter : MonoBehaviour
{

    public Slider slider;
    
    public void setMaxExposure(int exposure)
    {
        slider.maxValue = exposure;
        slider.value = exposure;
    }
    public void setExposure(int exposure)
    {
        slider.value = exposure;
    }
            
}
