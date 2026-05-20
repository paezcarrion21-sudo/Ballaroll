using UnityEngine;

public class DangerZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.ReSpawnPlayer();
        }
    }
}
