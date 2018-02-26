using UnityEngine;

public class CameraFollowFixedY : MonoBehaviour
{
    public Transform playerPosition;
    public float viewSize = 5;

    void Start()
    {
        this.GetComponent<Camera>().orthographicSize = viewSize;
    }

    void Update()
    {
        transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
    }
}
