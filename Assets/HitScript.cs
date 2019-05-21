using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Score;

public class HitScript : MonoBehaviour
{
    //Collision Function
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "HomeRunMid")
        {
            ScoreScript.score += 1000;
            Debug.Log(ScoreScript.score);
        }
        if (col.gameObject.name == "HomeRunLeft")
        {
            ScoreScript.score += 300;
            Debug.Log(ScoreScript.score);
        }
        if (col.gameObject.name == "HomeRunRight")
        {
            ScoreScript.score += 300;
            Debug.Log(ScoreScript.score);
        }
        if (col.gameObject.name == "Mid")
        {
            ScoreScript.score += 20;
            Debug.Log(ScoreScript.score);
        }
        if (col.gameObject.name == "BuntMid")
        {
            ScoreScript.score += 10;
            Debug.Log(ScoreScript.score);
        }
        if (col.gameObject.name == "MidRight")
        {
            ScoreScript.score += 50;
            Debug.Log(ScoreScript.score);
        }
        if (col.gameObject.name == "MidLeft")
        {
            ScoreScript.score += 50;
            Debug.Log(ScoreScript.score);
        }
    }
}
