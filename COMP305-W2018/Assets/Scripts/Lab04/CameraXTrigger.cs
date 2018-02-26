using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraXTrigger : MonoBehaviour
{
    public Camera mainCamera;
    public float newY = 0f;

    private void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, newY, mainCamera.transform.position.z);
        }
    }
}
