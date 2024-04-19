 
using UnityEngine;
using UnityEngine.Events;

public class TakeDamage : MonoBehaviour
{
    [SerializeField] private UnityEvent damgeCalculate; 

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Enemy")
        {
            damgeCalculate.Invoke(); 
        }
    }
}
