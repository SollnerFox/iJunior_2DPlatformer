using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private SpriteRenderer _sprite;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Update() 
    {
        var movement = Input.GetAxis("Horizontal");
        if (movement > 0)  _sprite.flipX = false;
        if (movement < 0) _sprite.flipX = true;
        //transform.position += new Vector3 (movement, 0f, 0f) * Time.deltaTime * _movementSpeed;
        gameObject.transform.Translate(new Vector3(movement, 0f, 0f) * Time.deltaTime * _movementSpeed);

        _animator.SetFloat("Speed", Mathf.Abs(movement));
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Jump") && Mathf.Abs(_rigidbody2D.velocity.y) < 0.01f)
        {
            _rigidbody2D.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
            _animator.SetBool("isJumping", true);
        }
        else
        {
            _animator.SetBool("isJumping", false);
        }
    }
}
