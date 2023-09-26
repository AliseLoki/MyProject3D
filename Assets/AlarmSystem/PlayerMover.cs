using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    private float _horizontalInput;
    private float _verticalInput;
    private float _speed = 5f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _horizontalInput = Input.GetAxis(Horizontal);
        _verticalInput = Input.GetAxis(Vertical);

        Vector3 movement = new Vector3(_horizontalInput, 0, _verticalInput);
        transform.Translate(movement * Time.deltaTime * _speed);
    }
}
