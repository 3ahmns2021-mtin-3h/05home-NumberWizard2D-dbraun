using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    public TextMeshProUGUI visibleGuess;
    public GameObject upButton;
    public GameObject downButton;
    public GameObject endButton;
    public GameObject restartButton;

    int min = 1;
    int max = 200;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        Restart();
    }

    private void NextGuess()
    {

        guess = (min + max) / 2;
        visibleGuess.text = guess.ToString();

    }

    public void LowerGuess()
    {
        max = guess - 1;
        NextGuess();
    }

    public void HigherGuess()
    {
        min = guess + 1;
        NextGuess();
    }

    public void CorrectGuess()
    {

        upButton.SetActive(false);
        downButton.SetActive(false);
        endButton.SetActive(false);
        restartButton.SetActive(true);

    }

    public void Restart()
    {

        min = 1;
        max = 200;
        NextGuess();
        upButton.SetActive(true);
        downButton.SetActive(true);
        endButton.SetActive(true);
        restartButton.SetActive(false);

    }
}