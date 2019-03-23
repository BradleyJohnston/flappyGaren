
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        Vector3 buffer = player.position;

        transform.position = new Vector3(
            buffer.x + 3, 2, -9);
    }
}
