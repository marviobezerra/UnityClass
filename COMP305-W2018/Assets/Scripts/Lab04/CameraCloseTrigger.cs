using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCloseTrigger : MonoBehaviour {

    public Camera mainCamera;
    public Camera closeCamera;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            mainCamera.enabled = false;
            closeCamera.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            closeCamera.enabled = false;
            mainCamera.enabled = true;
        }
    }
}
