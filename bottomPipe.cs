using UnityEngine;

public class bottomPipe : MonoBehaviour
{
    public GameObject player;
    public GameObject topCyl;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos.y = (float)(Random.value * 5) - 4;
        transform.position = pos;
        pos.y += 8.5f;
        topCyl.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 playPos = player.transform.position;

        if (playPos.x - pos.x >= 10)
        {
            pos.x += 30;
            pos.y = (float)(Random.value * 5) - 4;
            transform.position = pos;
            pos.y += 8.5f;
            topCyl.transform.position = pos;
        }
    }
}
