using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject GameOverPanel;
   public void SetScoreText(string txt)
    {
        if (scoreText ) {
            scoreText.text = txt;
        }
    }
    public void ShowGameOverPanel(bool isShow)
    {
        if (GameOverPanel)
        {
                        GameOverPanel.SetActive(isShow);
        }
    }

}
