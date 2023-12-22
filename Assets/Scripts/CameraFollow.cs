
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    public float timeOffset;
    public Vector3 posOffset;

    public Vector3 velocity;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + posOffset, ref velocity, timeOffset);
    }
}
