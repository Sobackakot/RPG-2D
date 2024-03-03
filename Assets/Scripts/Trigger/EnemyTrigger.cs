 
using UnityEngine;
using UnityEngine.Events;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private UnityEvent _onMoving;
    [SerializeField] private UnityEvent _continueMove;

    private void OnTriggerEnter2D(Collider2D uther)
    {
        if (uther.CompareTag("Finish") || uther.CompareTag("Enemy"))
        {
            _anim.SetBool("isMoving", false);
            _onMoving.Invoke();
        }
        else if(uther.CompareTag("Bullet"))
        {
            MainManager.Instance.money += 5;
            MainManager.Instance.countKill += 1;
            Destroy(gameObject);
            Destroy(uther.gameObject);
        }
            
    }
    private void OnTriggerExit2D(Collider2D item)
    {
        _anim.SetBool("isMoving", true);
        _continueMove.Invoke();
    }
}
    