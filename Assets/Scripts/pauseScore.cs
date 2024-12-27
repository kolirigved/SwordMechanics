using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pauseScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI self;

    void Update()
    {
        self.text = "Your Score: " + score.text;
    }
}
