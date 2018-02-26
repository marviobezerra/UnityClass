using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDelay : MonoBehaviour
{
    public Transform playerPosition;
    public Transform playerMoveThreshold;

    void Start()
    {
        playerMoveThreshold = transform.GetChild(0);
    }

    void Update()
    {
        if (playerPosition.position.x > playerMoveThreshold.position.x)
        {
            transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
        }
    }

    // Predefined Unity function for drawing Gizmos in the editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(playerMoveThreshold.position, new Vector3(playerMoveThreshold.position.x, playerMoveThreshold.position.y + 100, playerMoveThreshold.position.z));
        Gizmos.DrawLine(playerMoveThreshold.position, new Vector3(playerMoveThreshold.position.x, playerMoveThreshold.position.y - 100, playerMoveThreshold.position.z));
    }
}
