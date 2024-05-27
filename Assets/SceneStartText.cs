using UnityEngine;
using TMPro;

public class SceneStartText : MonoBehaviour
{
    public TextMeshProUGUI startText;
    public float displayTime = 3.0f;

    void Start()
    {
        startText.text = "In this scene, You have 150 seconds. you will learn about the locations and usage of various objects needed in a fire situation.";
        Invoke("HideText", displayTime);
    }

    void HideText()
    {
        startText.gameObject.SetActive(false);
    }
}