using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public RawImage gameOverImage;
    private int counter = 5;
    private bool gameOver = false;

    private void Start()
    {
        UpdateCounterText();
        gameOverImage.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!gameOver && collision.gameObject.CompareTag("Artifact"))
        {
            counter--;
            UpdateCounterText();

            if (counter <= 0)
            {
                counter = 0;
                GameOver();
            }
        }
    }

    private void UpdateCounterText()
    {
        counterText.text = counter.ToString();
    }

    private void GameOver()
    {
        gameOverImage.gameObject.SetActive(true);
        gameOver = true;
        Invoke("HideGameOver", 2f);
    }

    private void HideGameOver()
    {
        gameOverImage.gameObject.SetActive(false);
        gameOver = false;
    }
}
