using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Textbox : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject Player;

    private int index;
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        //STOP MOVEMENT SCRIPT HERE
        Player.GetComponent<Movement>().enabled = false;
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            //ALLOW MOVEMENT SCRIPT HERE
            Player.GetComponent<Movement>().enabled = true;
        }
    }
}
