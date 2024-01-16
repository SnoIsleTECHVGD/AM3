using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeLab : MonoBehaviour
{
    public GameObject winText;
    public GameObject Credits;
    public GameObject mainMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        winText.SetActive(true);
        Credits.SetActive(true);
        mainMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
