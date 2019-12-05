using UnityEngine;
using System.Collections;

public class DonutScript : MonoBehaviour
{

    private Rigidbody rb;
    CharacterController Rigidody;
    public float movementSpeed = 5.0f;
    private Vector3 moveDirection = Vector3.negativeInfinity;
    private float gravity;
    //private float move;
    //private float rotate;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if (Rigidbody.isGrounded)
        //{
        //move = Input.GetAxis("Vertical");
        //rotate = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection = moveDirection * movementSpeed;
        //Debug.Log(moveDirection);
        if (Input.GetButton("Jump"))
        {

        }


        {
            moveDirection.y -= gravity * Time.deltaTime;
            rb.AddForce(moveDirection * Time.deltaTime);

            //rb.transform.Rotate(rotate * Time.deltaTime, 0f, 0f);

            //}
        }
    }
}

