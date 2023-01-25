using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverText, RestartButton, OffButton, SuccessText, MessageText;
    int heart;
    bool isFinished;
    bool notFinished;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heart = Heart.heart;
        if(heart == 0)
        {
            GameOverText.SetActive(true);
            RestartButton.SetActive(true);
            OffButton.SetActive(true);
            Time.timeScale = 0;
        }

        isFinished = Finish.isFinished;
        if (isFinished)
        {
            SuccessText.SetActive(true);
            RestartButton.SetActive(true);
            OffButton.SetActive(true);
            Time.timeScale = 0;
        }

        notFinished = Finish.notFinished;
        if (notFinished)
        {
            GameObject.Find("Not Finished Sound").GetComponent<AudioSource>().Play();
            StartCoroutine(ShowMessage(2));
            Finish.isFinished = false;
            Finish.notFinished = false;
        }
    }

    IEnumerator ShowMessage(float delay)
    {
        MessageText.SetActive(true);
        yield return new WaitForSeconds(delay);
        MessageText.SetActive(false);
    }
}
