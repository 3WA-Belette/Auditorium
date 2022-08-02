using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulletReceiver : MonoBehaviour
{
    [SerializeField] int _bulletMax;        // Le score maximal atteignable pour notre objectif
    [SerializeField] float _idleDuration;   // La durée d'attente avant de baisser notre score
    [SerializeField] float _reductionSpeedInSeconds;   // La vitesse de reduction de notre score

    [Header("Audio")]
    [SerializeField] AudioSource _audio;    // L'audio que l'on va devoir moduler en fonction du score

    [Header("Gauge renderer")]
    [SerializeField, ColorUsage(true, true)] Color _onSprite; // Sprites color in gauge
    [SerializeField, ColorUsage(true, true)] Color _offSprite; // Sprites color in gauge
    [SerializeField] SpriteRenderer[] _gauge; // Sprites in gauge

    [Header("Event")]
    [SerializeField] UnityEvent _onBulletReceived;
    [SerializeField] UnityEvent _onObjectifComplete;
    [SerializeField] UnityEvent _onLevelFinished;

    float _currentScore;  // Le score actuel dans notre jeu
    float _lastBulletReceived;  // La date de la dernière reception d'une bullet

    void Start()
    {
        _currentScore = 0;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Si ya un composant bullet on fait un truc
        BulletMovement bullet = collision.GetComponentInParent<BulletMovement>();
        if(bullet != null)
        {
            float oldScore = _currentScore;   

            _currentScore = Mathf.Min(_currentScore + 1, _bulletMax);
            _lastBulletReceived = Time.time;
            Debug.Log($" Current score {_currentScore}");

            // Si on prend des bullets de base
            if(_currentScore < _bulletMax)
            {
                _onBulletReceived.Invoke();
            }
            // Si on vient de taper le score max
            else if(oldScore < _bulletMax && _currentScore >= _bulletMax)
            {
                _onObjectifComplete.Invoke();
            }
        }
    }

    private void Update()
    {
        // Si la date actuelle dépasse la date de la dernière bullet + duration
        if(Time.time > _lastBulletReceived + _idleDuration)
        {
            // Alors on descend notre score
            _currentScore = Mathf.Max(_currentScore - (_reductionSpeedInSeconds * Time.deltaTime), 0);
            Debug.Log($" Current score {_currentScore}");
        }

        // Combien on a rempli notre objectif ?
        float percent = _currentScore / _bulletMax;
        Debug.Log(percent);
        // En prenant ce pourcentage, ça représente combien de slot chez nous ?
        float gaugeCompletion = percent * _gauge.Length;
        // Mettre à jour le rendu de notre compteur
        for (int i = 0; i < _gauge.Length; i++)
        {
            if(i < gaugeCompletion)
            {
                _gauge[i].color = _onSprite;
            }
            else
            {
                _gauge[i].color = _offSprite;
            }
        }
        _audio.volume = percent;

        

    }

}
