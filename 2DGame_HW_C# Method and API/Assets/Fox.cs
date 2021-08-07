using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("²¾°Ê³t«×"),Range(0, 50)]
    public float speed = 20.0f;
    public Rigidbody2D rig;
    public SpriteRenderer Sr;

    private float gravity = 1;
    private float hValue;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetPlayerInputHorizontal();
        TurnDirection();
    }

    private void FixedUpdate()
    {
        Move(hValue);
    }


    private void GetPlayerInputHorizontal() 
    {
        hValue = Input.GetAxis("Horizontal");
    }

    private void Move(float horizontal)
    {
        Vector2 posMove = transform.position + new Vector3(horizontal, -gravity, 0) * speed * Time.deltaTime;
        rig.MovePosition(posMove);
    }

    private void TurnDirection()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = Vector3.zero;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
