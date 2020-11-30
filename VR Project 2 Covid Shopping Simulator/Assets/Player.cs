using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int maxExposure = 100;

    public int currentExposure;

    public Collider coll;


    public ExposureMeter exposureMeter;

    void Start()
    {
        currentExposure = maxExposure;
        exposureMeter.setMaxExposure(maxExposure);
        coll = GetComponent<Collider>();

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

    void ApplyHitPoints(Vector3 explosionPos, float radius)
    {
        Vector3 closestPoint = coll.ClosestPointOnBounds(explosionPos);
        float distance = Vector3.Distance(closestPoint, explosionPos);
        float damage = 1.0F - Mathf.Clamp01(distance / radius);

        int totalDamage = (int)damage;
        TakeDamage(totalDamage);
    }

    private void OnTriggerStay(Collider other) //when the object enters the trigger collider
    {
        if(other.gameObject.tag == "Enemy") { 
        ApplyHitPoints(other.gameObject.transform.position, 4);
            }
    }
}

