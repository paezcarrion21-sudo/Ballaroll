using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private int currScore;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {

        PlayerPrefs.DeleteKey("score");
        LoadScore();
        LoadUiScore();
    }


    public void AddScore(int score)
    {

        currScore = currScore + score;
        LoadUiScore();
        SaveScore();
    }
    public void SubstartScore(int score)
    {
        currScore = currScore - score;
        LoadUiScore();
        SaveScore();
    }
    private void LoadScore()
    {
        Debug.Log("Se carga el puntaje guardado");
        currScore = PlayerPrefs.GetInt("score");
    }
    private void SaveScore()
    {
        Debug.Log("Se guarda el puntaje");
        PlayerPrefs.SetInt("score", currScore);

    }
    private void LoadUiScore()
    {

        scoreText.text = currScore.ToString();

    }

}
