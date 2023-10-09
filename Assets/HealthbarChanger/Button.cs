using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private int _changeValue;
    [SerializeField] private Player _player;

    public void OnButtonClick()
    {
        _player.ChangeHealth(_changeValue);
    }
}
