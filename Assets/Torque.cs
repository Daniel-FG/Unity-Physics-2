using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{
    public Vector3 torque;
    public float torqueTime;

    private Rigidbody rigidBody;
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(torqueTime >= 0f)
        {
            rigidBody.AddTorque(torque);
            torqueTime = torqueTime - Time.fixedDeltaTime;
        }
    }
}
