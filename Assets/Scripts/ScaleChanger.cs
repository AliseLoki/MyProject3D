using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private float _growingSpeed;

    void Update()
    {
        transform.localScale += new Vector3(_growingSpeed * Time.deltaTime, _growingSpeed * Time.deltaTime, _growingSpeed * Time.deltaTime);
    }
}
