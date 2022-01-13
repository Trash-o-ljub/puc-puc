using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoother : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + offset.y, target.position.z + offset.z);
        transform.LookAt(target);
    }
}
