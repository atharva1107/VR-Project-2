using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int maxExposure = 100;

    public int currentExposure;

    public ExposureMeter exposureMeter;

    void Start()
    {
        currentExposure = maxExposure;
        exposureMeter.setMaxExposure(maxExposure);
        
    }

    void Update()
    {

        //This is for taking damage. anytime we calculate that distance between player and enemy and it's less than "6 feet" take continous damage
        //
        StartCoroutine(WaitForSeconds());
    
        
    }
    IEnumerator WaitForSeconds()
    {
        //TakeDamage(1);

        yield return new WaitForSecondsRealtime(1);

    }
    void TakeDamage(int damage)
    {
        currentExposure -= damage;
        exposureMeter.setExposure(currentExposure);

    }

}
