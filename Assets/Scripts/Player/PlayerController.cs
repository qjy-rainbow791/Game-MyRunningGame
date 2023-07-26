using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Behaviour to handle keyboard input and also store the player's
 * current health.
 */
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private bool canJump;
    private float y;

    /*
     * Apply initial health and also store the Rigidbody2D reference for
     * future because GetComponent<T> is relatively expensive.
     */
    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        y = transform.position.y;
    }

    public bool CanJump()
    {
        return canJump;
    }

    /*
     * When a character takes damage, it is redirected to the EndGame Scene
     */
    public void Damage()
    {
        SceneManager.LoadScene("EndGame");
    }
    /*
     * Poll keyboard for when the up arrow is pressed. If the player can jump
     * (is on the ground) then add force to the cached Rigidbody2D component.
     * Finally unset the canJump flag so the player has to wait to land before
     * another jump can be triggered.
     */
    private void Update()
    {
        float nowY = transform.position.y;
        if (nowY - y < -2)
        {
            Damage();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (canJump == true)
            {
                rigidbody2d.AddForce(new Vector2(0, 500));
                canJump = false;
            }
        }
    }

    /*
     * If the player has collided with the ground, set the canJump flag so that
     * the player can trigger another jump.
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        canJump = true;
    }

}
