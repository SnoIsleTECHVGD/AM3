using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthChange : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public Stats PlayerStats;

    // Update is called once per frame
    void Update()
    {
        Text.text = PlayerStats.health + "/3 Hearts";
    }
}