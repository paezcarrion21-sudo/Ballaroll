using UnityEngine;

public class ObstecleRotation : MonoBehaviour
{
   
    [SerializeField] private float speed;
    [SerializeField] private GameObject obstacleObj;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 currTargetPosition;
    [SerializeField] private float speedRotation;

    private void Start()
    {
        startPosition = obstacleObj.transform.position;
       
    }

    private void Update()
    {
        obstacleObj.transform.Rotate(Vector3.back, speedRotation * Time.deltaTime);
        if (obstacleObj.transform.position != currTargetPosition)
        {
            obstacleObj.transform.position = Vector3.MoveTowards(obstacleObj.transform.position, currTargetPosition, speed * Time.deltaTime);
        }
    
        
    }
}
