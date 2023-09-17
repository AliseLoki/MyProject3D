using UnityEngine;

public class MixChanges : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _angle;
    [SerializeField] private float _growingSpeed;
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(0, _angle * _rotationSpeed * Time.deltaTime, 0);
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        transform.localScale += new Vector3(_growingSpeed * Time.deltaTime, _growingSpeed * Time.deltaTime, _growingSpeed * Time.deltaTime);
    }
}
