using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lost : MonoBehaviour
{
    public int lost=0;
    public TextMeshProUGUI lostText;
    public TextMeshProUGUI finalScore;
    public int gameOverCount = 10;
    public GameObject gameOverPanel;
    public GameObject text;
    public GameObject pauseButton;
      
    void Update()
    {
        lostText.text = "LOST " + lost;
        if(lost==gameOverCount)
        {
            Time.timeScale = 0f;
            gameOverPanel.SetActive(true);
            text.SetActive(false);
            pauseButton.SetActive(false);
            
            finalScore.text="CAUGHT "+GameObject.Find("Player").GetComponent<PlayerMovement>().caught;
        }
    }

    public void IncreseLost()
    {
        lost = lost + 1;
    }
}
