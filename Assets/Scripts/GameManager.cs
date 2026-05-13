
using System.ComponentModel;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private ScoreController scoreController;
    void Start()
    {
        if (instance == null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
    }
    public void ChangeScore(int newScore)
    {
        scoreController.AddScore(newScore);
    }
    public void ClearPlayerPref()
    {
        PlayerPrefs.DeleteAll();

    }
}
