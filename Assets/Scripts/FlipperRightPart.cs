using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperRightPart : MonoBehaviour
{
    public ParticleSystem myPart;

    private void Start()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {
            StartPart(col);
        }
    }
    void StartPart(Collision col)
    {
        myPart.Play();
    }
}
