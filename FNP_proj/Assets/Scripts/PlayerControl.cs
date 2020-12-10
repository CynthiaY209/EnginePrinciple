using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float turnSpeed = 20f;

    Vector3 m_Movement;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    Quaternion m_Rotation = Quaternion.identity;
 

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Get Input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normalize();

        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool isMoving = hasHorizontalInput || hasVerticalInput;
        m_Animator.SetBool("isMoving", isMoving);

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation(desiredForward);
     }

    private void OnAnimatorMove()
    {
        //Debug.Log(m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MovePosition(m_Rigidbody.position + m_Movement * 0.1f);
        m_Rigidbody.MoveRotation(m_Rotation);
    }
}

