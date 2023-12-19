using UnityEngine;

public class EnnemiPatrol : MonoBehaviour
{

    [SerializeField]
    public float Speed;
    public Transform[] waypoints;


    public SpriteRenderer graphics;
    private Transform target;
    private int destPoint = 0;



    void Start()
    {
        target = waypoints[0];
    }

 
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * Speed * Time.deltaTime, Space.World);

        // If ennemies near target
        if (Vector3.Distance(transform.position, target.position)< 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
            graphics.flipX = !graphics.flipX;
        }
    }
}
