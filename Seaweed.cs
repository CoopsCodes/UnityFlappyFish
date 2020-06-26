using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Seaweed : MonoBehaviour
{
    // OnCollisionEnter is used to indicate when two objects have collided(touched)
    private void OnCollisionEnter2D(Collision2D collide)
    {
        // Indicating if the collide.collider intersects with the GetComponent object
        {
            if (collide.collider.GetComponent<Fish>() != null)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
