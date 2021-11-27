using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class 점수결과 : MonoBehaviour
{
    private TextMeshProUGUI textResultScore;

    private void Update()
    {
        textResultScore = GetComponent<TextMeshProUGUI>();

        int score = PlayerPrefs.GetInt("Score");

        textResultScore.text = "ZUMSU : " + score;

    }

}
