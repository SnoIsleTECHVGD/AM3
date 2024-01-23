using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartDissapear : MonoBehaviour
{
    public int Vanish;
    public GameObject Player;
    public GameObject Heart;
    void Start()
    {
        
    }
    void Update()
    {
        if (Player.GetComponent<Stats>().health < Vanish)
        {
            Heart.SetActive(false);
        }
    }
}
