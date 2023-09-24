using UnityEngine;

public class AxisYRotater : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _angle;

    private void Update()
    {
        transform.Rotate(0, _angle * _rotationSpeed * Time.deltaTime, 0);
    }
}
