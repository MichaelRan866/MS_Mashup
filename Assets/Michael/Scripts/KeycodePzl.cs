using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class KeycodePzl : MonoBehaviour
{
    public TextMeshProUGUI codeDisplay;
    public UnityEvent onCorrect;
    public string correctAnswer;
    public AudioClip keySnd;
    public AudioClip dingSnd;
    public AudioClip buzzSnd;

    private void OnEnable()
    {
        codeDisplay.text = "";
    }
    private void OnDisable()
    {
        GameManager.menuOpen = false;
    }

    public void AddChar(string newChar) 
    {
        codeDisplay.text += newChar;
        if (codeDisplay.text.Length >= correctAnswer.Length)
        {
            if (codeDisplay.text == correctAnswer)
            {
                onCorrect.Invoke();
                GameManager.PlaySnd(dingSnd);
            }
            else
            {
                codeDisplay.text = "";
                GameManager.PlaySnd(buzzSnd);
            }
        }
        else 
        {
            GameManager.PlaySnd(keySnd);
        }
    }
}
