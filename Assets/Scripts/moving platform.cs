using System.Collections;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    [SerializeField] private float speed = 10f;

    private bool isPlayerOnPlatform = false;
    private Vector3 targetPosition;

    void Start()
    {
        transform.position = pointA.transform.position; 
        targetPosition = pointB.transform.position; 
    }

    public void StartMoving()
    {
        isPlayerOnPlatform = true;
        StartCoroutine(MovePlatform());
    }

    private IEnumerator MovePlatform()
    {
       
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            yield return null;
        }

       
        isPlayerOnPlatform = false;
    }

    public void StopMoving()
    {
        isPlayerOnPlatform = false; 
    }
}

