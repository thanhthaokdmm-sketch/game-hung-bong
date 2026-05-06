using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;

    float m_spawnTime;

    int m_score;
    bool m_isGameOver;

    UIManager m_ui;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.SetScoreText("Score: " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;

        if(m_isGameOver)
        {
            m_spawnTime = 0;
            m_ui.ShowGameOverPanel(true);
            return;
        }
        if(m_spawnTime <= 0)
        {
            SpawnBall();
            m_spawnTime = spawnTime;
        }
    }
    public void SpawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-7f, 7f), 6f);
        if(ball)
        {
                        Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }
    public void replay()
    {
        m_score = 0;
        m_isGameOver = false;
        m_ui.SetScoreText("Score: " + m_score);
        m_ui.ShowGameOverPanel(false);
    }
    public void SetScore( int value)
    {
        m_score = value;
    }
    public int GetScore()
    {
        return m_score;
    }
     public void IncrementScore()
    {
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }
    public bool IsGameOver()
    {
        return m_isGameOver;
    }
     public void SetGameOverState(bool state)
    {
        m_isGameOver = state;
    }
}
