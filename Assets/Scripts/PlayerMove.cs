using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rigidbody;
    public float speed;
    public float SlideSpeed;
    private bool IsRight = false;
    private bool IsLeft = true;
    private bool TurnCenter = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(0, 0, speed * Time.deltaTime));

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && !IsLeft)
        {
            Vector3 newPos = transform.position;
            newPos.x -= 3.0f;
            transform.position = newPos;
            IsLeft = true;
        }
        else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && !IsRight)
        {
            Vector3 newPos = transform.position;
            newPos.x += 3.0f;
            transform.position = newPos;
            IsRight = true;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(0, 0, -(speed * Time.deltaTime));
        }
    }
}
