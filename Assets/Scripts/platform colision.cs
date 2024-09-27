using UnityEngine;

public class PlatformCollision : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private Transform platform; 
    [SerializeField] private movingplatform movingPlatform;
    public GameObject GameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
           // other.transform.parent = platform; 
            movingPlatform.StartMoving(); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            //GetComponent<GameStateManager>();

           // other.transform.parent = null;
            //other.gameObject.parent = GameManager;
            movingPlatform.StopMoving(); 
        }
    }
}
