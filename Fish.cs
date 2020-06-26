using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] // This creates displays in the editor
    private float jumpForce = 500f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
	{
		if (Input.GetButtonDown("Fire1"))
        {
            // this is stopping th downward velocity so the jump van be performed again
            rb.velocity = Vector2.zero;

            // this is the jump action using the .up and multiplying it by the jumpForce
            rb.AddForce(Vector2.up * jumpForce);
        }
	}
}
