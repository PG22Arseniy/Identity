using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_BlockEffect : MonoBehaviour
{
    [Range(0, 1000)]
    public float moveForward;
    [Range(0, 1000)]
    public float moveBackward;
    [Range(0, 1000)]
    public float jumpForce;



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out CharacterMovement2D playerMovement))
        {
            Rigidbody2D rb = playerMovement.GetComponent<Rigidbody2D>();

            if (rb != null)
                rb.AddForce(Vector2.right * moveForward);
            if (rb != null)
                rb.AddForce(Vector2.left * moveBackward);
            if (rb != null)
                rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
