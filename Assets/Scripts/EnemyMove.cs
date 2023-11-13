 
using UnityEngine;

public class EnemyMove : MonoBehaviour
{  
    void Update()
    {
        transform.position += -transform.right * 1f * Time.deltaTime; 
    }
}
