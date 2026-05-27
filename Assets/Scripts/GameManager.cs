using System.ComponentModel;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private ScoreController scoreController;
    private Vector3 currSpawnPlayer;
    public Vector3 CurrSpawnPlayer { get => currSpawnPlayer; set => currSpawnPlayer = value; }
    public GameObject Player;
    void Start()
    {
        if (instance == null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;

        Vector3 startPosition = Player.transform.position;
        CurrSpawnPlayer = Player.transform.position;
    }
    public void ChangeScore(int newScore)
    {
        scoreController.AddScore(newScore);
    }
    public void ClearPlayerPref()
    {
        PlayerPrefs.DeleteAll();

    }
    public void ReSpawnPlayer()
    {
        Player.SetActive(false);
        Player.transform.position = CurrSpawnPlayer;
        Player.SetActive(true);
        Player.GetComponent<PlayerController>().rb.angularVelocity = Vector3.zero;
        Player.GetComponent<PlayerController>().rb.linearVelocity = Vector3.zero;
    }
}
