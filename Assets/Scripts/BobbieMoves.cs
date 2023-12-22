
using UnityEngine;

public class BobbieMoves : MonoBehaviour
{
    [SerializeField]
    public float m_Speed;
    public float m_JumpForce;

    [SerializeField]
    public Rigidbody2D m_Rigidb;
    public Animator m_Animator;
    public SpriteRenderer spriteRenderer;

    [SerializeField]
    public float m_PlayerHeight;


    [SerializeField]
    public Transform groundCheckLeft;
    public Transform groundCheckRight;

    private bool _jumping;
    private bool _grounded;


    public static BobbieMoves instance;


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de BobbieMoves dans la scène");
            return;
        }

        instance = this;
    }



    void Update()
    {
        if (Input.GetButtonDown("Jump") && _grounded)
        {
            _jumping = true;
        }


    }

    void FixedUpdate()
    {
        float characterVelocity = Mathf.Abs(m_Rigidb.velocity.x);

        _grounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);

        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f)
        {

            m_Rigidb.velocity = new Vector2(Input.GetAxis("Horizontal") * m_Speed, m_Rigidb.velocity.y);
        }

        if (_jumping)
        {

            m_Rigidb.AddForce(new Vector2(0, m_JumpForce));
            _jumping = false;
        }

        Flip(m_Rigidb.velocity.x);
        m_Animator.SetFloat("Speed", characterVelocity);

    }

    void Flip(float _velocity)
    {
        if (_velocity > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if (_velocity < -0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }
}
