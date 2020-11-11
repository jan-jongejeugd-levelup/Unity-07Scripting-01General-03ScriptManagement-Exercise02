using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    [SerializeField] private float _projectileForce = 20;
    [SerializeField] private Rigidbody _rb;

    public void Init(Vector3 delta)
    {
        _rb.AddForce(delta.normalized * _projectileForce);
    }
}
