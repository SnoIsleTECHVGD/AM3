using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Textbox : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] GameObject TextandNameandImage;
    Textbox ourTextNameFace;

    [Header("References")]
    TextMeshProUGUI boxText;
    TextMeshProUGUI boxName;
    RawImage boxFace;
    RawImage boxImage;
    RectTransform boxRectTransform;
    Textbox instance;
    Canvas Canvas;

    [Header("Textbox")]
    [SerializeField] Texture2D texture;

    [Header("Typing")]
    [SerializeField] float delayBeforeSpeaking;
    [SerializeField] float delayAfterSpeaking = 0;
    [SerializeField] float charDelay = 1;
    [SerializeField] float basecharDelay =1;
    public bool isSpeaking;

    private void Awake()
    {
        instance = this;
        Textbox.ourbox = instance;
        boxText = transform.Find("Text").gameObject.GetComponent<TextMeshProUGUI>();
        boxName = transform.Find("Name").gameObject.GetComponent<TextMeshProUGUI>();
        boxFace = transform.Find("Face").gameObject.GetComponent<RawImage>();

        ourTextNameFace = TextandNameandImage.GetComponentInChildren<Textbox>();
        Canvas = FindObjectOfType<Canvas>();

        boxImage = GetComponent<RawImage>();
        boxRectTransform = GetComponent<RectTransform>();
        boxRectTransform.offsetMin = Vector2.zero();
        boxRectTransform.offsetMax = Vector2.zero();
        ChangeBoxImage(texture);

        boxText.maxVisibleCharacters = 0;
        boxName.maxVisibleCharacters = 0;
    }
}
