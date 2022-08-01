using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletReceiver : MonoBehaviour
{
    [SerializeField] int _bulletMax;        // Le score maximal atteignable pour notre objectif
    [SerializeField] float _idleDuration;   // La durée d'attente avant de baisser notre score

    [Header("Gauge renderer")]
    [SerializeField, ColorUsage(true, true)] Color _onSprite; // Sprites color in gauge
    [SerializeField, ColorUsage(true, true)] Color _offSprite; // Sprites color in gauge
    [SerializeField] SpriteRenderer[] _gauge; // Sprites in gauge

    int _currentScore;  // Le score actuel dans notre jeu
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
            _currentScore = Mathf.Min(_currentScore + 1, _bulletMax);
            _lastBulletReceived = Time.time;
            Debug.Log($" Current score {_currentScore}");
        }
    }

    private void Update()
    {
        // Si la date actuelle dépasse la date de la dernière bullet + duration
        if(Time.time > _lastBulletReceived + _idleDuration)
        {
            // Alors on descend notre score
            _currentScore = Mathf.Max(_currentScore - 1, 0);
            Debug.Log($" Current score {_currentScore}");
        }

        // Combien on a rempli notre objectif ?
        float percent = (float)_currentScore / (float)_bulletMax;
        // En prenant ce pourcentage, ça représente combien de slot chez nous ?
        float gaugeCompletion = percent * _gauge.Length;
        Debug.Log(gaugeCompletion);
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
    }

}
