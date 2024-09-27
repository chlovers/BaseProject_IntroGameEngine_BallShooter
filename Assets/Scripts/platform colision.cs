using UnityEngine;

public class PlatformCollision : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private Transform platform; 
    [SerializeField] private movingplatform movingPlatform;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            other.transform.parent = platform; 
            movingPlatform.StartMoving(); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            other.transform.parent = null; 
            movingPlatform.StopMoving(); 
        }
    }
}
