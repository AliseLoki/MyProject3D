using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _currentHealth;

    private int _minHealth;

    public event UnityAction<int> HealthChanged;

    private void Start()
    {
        _currentHealth = _maxHealth;
        HealthChanged?.Invoke(_currentHealth);
    }

    public void ChangeHealth(int value)
    {
        _currentHealth += value;

        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;

        if (_currentHealth < _minHealth)
            _currentHealth = _minHealth;

        HealthChanged?.Invoke(_currentHealth);
    }
}
