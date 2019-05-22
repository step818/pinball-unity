using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLife : MonoBehaviour
{
    void OnTriggerEnter (Collider col)
    {
        Debug.Log("Object entered the trigger");
        GameControlScript.health -= 1;
    }
}
