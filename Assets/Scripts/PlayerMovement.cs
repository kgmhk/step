using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 0.5F;

    Rigidbody2D rb;
    BoxCollider2D _coll;
    SpriteRenderer _render;
    AudioSource _audio;
    [SerializeField] private LayerMask jumpLayer;
    [SerializeField] private AudioSource gainAudio;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        _coll = GetComponent<BoxCollider2D>();
        _render = GetComponent<SpriteRenderer>();
        _audio = GetComponent<AudioSource>();
    }

    void Update() {
        float xMove = CrossPlatformInputManager.GetAxis("Horizontal");
        float zMove = CrossPlatformInputManager.GetAxis("Vertical");
        // rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed;
        rb.velocity = new Vector3(xMove * speed, rb.velocity.y);
        if (CrossPlatformInputManager.GetAxis("Horizontal") > 0) {
            _render.flipX = false;
        } else if (CrossPlatformInputManager.GetAxis("Horizontal") < 0) {
            _render.flipX = true;
        }
        // Debug.Log("diry : "+ dirY);
        if (CrossPlatformInputManager.GetButtonDown("Jump") && IsGrounded())
        {
            // ScoreManager.instance.score++;
            // Debug.Log(" -- " + ScoreManager.instance.score);
            // jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, gravity);
            _audio.Play();
        }
    }

    private bool IsGrounded() {
        print("tag " + _coll.gameObject.tag);
        return Physics2D.BoxCast(_coll.bounds.center, _coll.bounds.size, 0f, Vector2.down, .1f, jumpLayer);

    }

    private void OnTriggerEnter2D(Collider2D other) {
        print("OnTrriger");
        ScoreManager.instance.score++;
        gainAudio.Play();
        Destroy(other);

    }
}
