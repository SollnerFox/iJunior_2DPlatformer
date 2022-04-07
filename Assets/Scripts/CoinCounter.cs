using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
    [SerializeField] private Text _scoreText;
    private int score;
    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        _scoreText.text = "Apples: " + score.ToString();
    }
}
