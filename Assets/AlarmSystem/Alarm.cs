using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioClip _alarm;

    private AudioSource _alarmSource; 
    private float _duration = 3f;

    private void Start()
    {
        _alarmSource = GetComponent<AudioSource>();
    }

    public IEnumerator ChangeVolume(float targetVolume)
    {
        _alarmSource.Play();

        while (_alarmSource.volume != targetVolume)
        {
            _alarmSource.volume = Mathf.MoveTowards(_alarmSource.volume, targetVolume, _duration * Time.deltaTime);
            yield return null;
        }
    }
}
