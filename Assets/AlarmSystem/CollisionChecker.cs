using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    private const float MinVolume = 0;
    private const float MaxVolume = 1;

    [SerializeField] private Alarm _alarm;

    private Coroutine _coroutine;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out PlayerMover player))
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }

            _coroutine = StartCoroutine(_alarm.ChangeVolume(MaxVolume));
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.TryGetComponent(out PlayerMover player))
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }

            _coroutine = StartCoroutine(_alarm.ChangeVolume(MinVolume));
        }
    }
}
