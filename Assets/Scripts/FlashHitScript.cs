using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashHitScript : MonoBehaviour
{
    public Transform hitTrigger;
    // Start is called before the first frame update
    void Start()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        hitTrigger.GetComponent<ParticleSystem>().enableEmission = false;
#pragma warning restore CS0618 // Type or member is obsolete
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        hitTrigger.GetComponent<ParticleSystem>().enableEmission = true;
#pragma warning restore CS0618 // Type or member is obsolete
        StartCoroutine (stopHitTrigger ());
    }
    IEnumerator stopHitTrigger()
    {
        yield return new WaitForSeconds(.4f);
#pragma warning disable CS0618 // Type or member is obsolete
        hitTrigger.GetComponent<ParticleSystem>().enableEmission = false;
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
