using UnityEngine;

[RequireComponent(typeof(PlayerBehaviour))]
public class PlayerController : MonoBehaviour
{

    private PlayerBehaviour _playerBehaviour;
    private ProjectileBehaviour _projectileBehaviour;

    private void Awake()
    {
        _playerBehaviour = GetComponent<PlayerBehaviour>();
        _playerBehaviour.Init();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontal, vertical, 0);
        _playerBehaviour.Move(direction);

        if (Input.GetButtonDown("Fire1"))
        {
            var mouseInput = Input.mousePosition;
            mouseInput.z = 10;
            var mousePosition = Camera.main.ScreenToWorldPoint(mouseInput);
            mousePosition.z = 0;
            var projectileDelta = mousePosition - transform.position;
            _playerBehaviour.Shoot(projectileDelta);
        }
    }

}
