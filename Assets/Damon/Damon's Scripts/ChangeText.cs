using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshPro Text;
    public Stats PlayerStats;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = PlayerStats.health + "/3 Hearts";  
    }
}
