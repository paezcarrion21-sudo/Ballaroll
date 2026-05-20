using UnityEngine;

public class CheckpointHandle : MonoBehaviour
{
    private bool isActive = true;
    [SerializeField] private Transform spawnPosition;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isActive)
        {
            GameManager.instance.CurrSpawnPlayer = spawnPosition.position;
            isActive = false;
        }
    }
}
