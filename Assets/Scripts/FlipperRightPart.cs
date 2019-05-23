using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperRightPart : MonoBehaviour
{
    public ParticleSystem myPart;

    private void Start()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "RightTrigger")
        {
            StartPart(col);
        }
    }
    void StartPart(Collider col)
    {
        myPart.Play();
    }
}
