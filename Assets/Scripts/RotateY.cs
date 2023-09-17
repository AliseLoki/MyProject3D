using UnityEngine;

public class RotateY : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _angle;

    void Update()
    {
       transform.Rotate(0,_angle*_rotationSpeed*Time.deltaTime,0);
    }
}
