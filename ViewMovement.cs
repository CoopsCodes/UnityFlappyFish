using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.5f;

    // Update is called once per frame
    private void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
    }
}
