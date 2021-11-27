using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class 스코어 : MonoBehaviour
{
    [SerializeField]
    private Playercontroller PlayerController;
    private TextMeshProUGUI textScore;

    private void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textScore.text = "Zumsu " + PlayerController.Score;


    }

}
