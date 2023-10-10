using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class Healthbar : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Player _player;

    private Slider _slider;
    private Coroutine _coroutine;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _player.HealthChanged += Change;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= Change;
    }

    private void Change(int health)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(ChangehealthBar(health));
    }

    private IEnumerator ChangehealthBar(int health)
    {
        while (enabled)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, health, _duration * Time.deltaTime);
            yield return null;
        }
    }
}
