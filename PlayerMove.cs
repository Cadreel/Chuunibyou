using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal") / speed;
        float moveVertical = Input.GetAxis ("Vertical") / speed;

        Debug.Log(moveHorizontal);
        Debug.Log(moveVertical);

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        transform.position += movement;
        //rb.AddForce (movement * speed);
    }
}