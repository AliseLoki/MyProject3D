using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private float _duration;
    [SerializeField] private int _currentHealth;
    [SerializeField] private Slider _healthbar;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _healthbar.value = _currentHealth;
    }

    private void Update()
    {
        _healthbar.value = Mathf.MoveTowards(_healthbar.value, _currentHealth, _duration * Time.deltaTime);
    }

    public void ChangeHealth(int value)
    {
        _currentHealth += value;

        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;
    }
}
