using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{

    public Text scoretext;
    float score;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("player") != null)
        {
            score += 1 * Time.deltaTime;
            scoretext.text = ((int)score).ToString();
        }
    }
}
