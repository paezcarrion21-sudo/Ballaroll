using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private int currScore;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        LoadScore();
    }
    void OnTestE()
    {
     AddScore();
     }
    void OnTestQ()
    {
     SubstartScore();
    }
    
    private void AddScore()
    {

        currScore++;
        LoadUiScore();
    }
    private void SubstartScore()
    {
        currScore--;
        LoadUiScore();
    }
    private void LoadScore()
    {
        Debug.Log("Se carga el puntaje guardado");

    }
    private void LoadUiScore()
    {

        scoreText.text = currScore.ToString();

    }
}
