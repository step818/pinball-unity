using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{

    void Update()
    {
        if (transform.position.z < -16)
            Respawn();
    }

    private void Respawn()
    {
        transform.position = new Vector3(3, 0.228f, -2);

        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;

    }
}
