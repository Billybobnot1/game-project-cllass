using UnityEngine; 
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{

    float movementX;
    float movementY;
    [SerializeField] float speed = 6f;

    [SerializeField] Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();

        movementX = v.x;
        movementY = v.y;

        Debug.Log(v);

    }
    void FixedUpdate()
    {
        float xmoveDistance = movementX * speed * Time.fixedDeltaTime;
        float ymoveDistance = movementY * speed * Time.fixedDeltaTime;

        transform.position = new Vector2(transform.position.x + xmoveDistance, transform.position.y + ymoveDistance);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(new Vector2(0, 200));
        Debug.Log("bounce");
    }

}
