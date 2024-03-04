 
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent onMoveEnable;
    [SerializeField] private UnityEvent onMoveDesable;

    [SerializeField] private Animator _anim; 
    [SerializeField] private Image hp;
     
    private float currentHpEnemy = 100f;
     
    private void UpdateHpEnemy()
    {
        currentHpEnemy -= 25f;
        if (currentHpEnemy <= 0f)
        {
            MainManager.Instance.countKill += 1;
            MainManager.Instance.countMoney += 5;
            Destroy(gameObject);
        }
        else 
            hp.fillAmount = currentHpEnemy / 100;
    } 
    private void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.CompareTag("Bullet"))
        {
            UpdateHpEnemy();
            Destroy(other.gameObject);
        } 
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Finish") || other.CompareTag("Enemy"))
        {
            _anim.SetBool("isMoving", false);
            onMoveDesable.Invoke(); 
        }
    }

    private void OnTriggerExit2D(Collider2D item)
    {
        _anim.SetBool("isMoving", true);
        onMoveEnable.Invoke();
    }  
}
    