using System.Collections; 
using TMPro;
using UnityEngine;

public class TakeDamaje : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _hpText;   

    private float _hp = 100f;
    private Coroutine _coroutine;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        { 
            if (_coroutine == null)
            {
                _coroutine = StartCoroutine(TakeDamage());
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        { 
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }
    }

    private IEnumerator TakeDamage()
    {
        while (true)
        {
            if (_hp <= 0) break;
            yield return new WaitForSeconds(0.5f);
            _hp -= 5f;
            _hpText.text = _hp.ToString(); 
        }
    }
}
