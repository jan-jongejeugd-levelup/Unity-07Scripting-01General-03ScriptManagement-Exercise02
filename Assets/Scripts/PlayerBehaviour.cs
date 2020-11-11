using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody _projectile;
    [SerializeField] private float _speed = 5;

    private ProjectileBehaviour _projectileBehaviour;


    public void Init()
    {
        _projectileBehaviour = _projectile.GetComponent<ProjectileBehaviour>();
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    public void Shoot(Vector3 delta)
    {
        //Pq usar var en vez de le tipo?
        ProjectileBehaviour projectile = Instantiate(_projectileBehaviour, transform.position, Quaternion.identity);
        projectile.Init(delta);
    }
}
