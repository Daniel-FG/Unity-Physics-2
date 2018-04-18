using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//加入此行後即使是在編輯模式中  只要Scene有變動就會跑update
[ExecuteInEditMode]
public class ShowStats : MonoBehaviour
{
    private Rigidbody rigidBody;
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update ()
    {
        Debug.Log(rigidBody.inertiaTensor);
	}
}
