using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{

    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + ItemCollector.pineapples;
    }
}
