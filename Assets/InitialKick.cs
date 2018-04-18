using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialKick : MonoBehaviour
{
    public Vector3 angularVelocity;

    private Rigidbody rigidBody;
    private void OnEnable()  //使用OnEnable()可以確保Script執行順序不會影響  會優先進行  OnEnable()優先執行於Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.angularVelocity = angularVelocity;
    }
}
