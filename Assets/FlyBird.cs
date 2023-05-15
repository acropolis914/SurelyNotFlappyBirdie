using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBird : MonoBehaviour {

    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    private bool hasTapped = false;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        rb.position = new Vector2(-5.0f, 0.0f); // Set initial position to left side of screen
    }

    // Update is called once per frame
    void Update() {
        if (!hasTapped && Input.GetMouseButtonDown(0)) {
            // First tap, allow movement and center the object
            hasTapped = true;
            rb.constraints = RigidbodyConstraints2D.None;
            rb.velocity = Vector2.up * velocity; // Make the bird fly up on the first tap
        }
        else if (hasTapped && Input.GetMouseButtonDown(0))
        {
            // Jump
            rb.velocity = Vector2.up * velocity;
        }

        if (hasTapped && rb.position.x < 0.0f)
        {
            // Move the bird towards the center of the screen
            rb.position = Vector2.MoveTowards(rb.position, Vector2.zero, Time.deltaTime * 1.0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
