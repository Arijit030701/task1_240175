using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerPos;
    public float offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = transform.position;
        cameraPos.z = playerPos.position.z + offset;
        transform.position = cameraPos;
    }
}
