using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int points;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.instance.ChangeScore(points);
            Debug.Log("Entro en el trigger");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Esta en el trigger");
            Destroy(gameObject);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            Debug.Log("Salio del trigger");
        }
    }

}
