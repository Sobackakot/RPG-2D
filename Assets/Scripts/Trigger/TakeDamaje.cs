 
using UnityEngine;
using UnityEngine.Events;

public class TakeDamaje : MonoBehaviour
{
    [SerializeField] private UnityEvent damgeCalculate; 

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("Enemy"))
        {
            damgeCalculate.Invoke();
        }
    }
}
