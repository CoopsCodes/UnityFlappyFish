using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;

    private float posX = -15f;

    [SerializeField]
    private float randomOffset = 2f;

    // Update is called once per frame
    private void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;

        if (transform.position.x <= posX)
        {
            // generating a random number within the randomOffset paramater
            float randomHeight = Random.Range(-randomOffset, randomOffset);

            // the transform position associated to the gameObject (ie seaweed in this case)
            // assigned to a new Vector position taking in the (X, Y, Z) as parameters.
            transform.position = new Vector3(15, randomHeight, 0);
        }
    }
}
