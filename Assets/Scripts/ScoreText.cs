using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Score;

public class ScoreText : MonoBehaviour
{
    public TextMesh scoreText;
    // Start is called before the first frame update
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + ScoreScript.score;
    }
}
