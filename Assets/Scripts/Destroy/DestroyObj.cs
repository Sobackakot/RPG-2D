 
using UnityEngine;
using UnityEngine.Events;

public class DestroyObj : MonoBehaviour
{    
    private void OnTriggerEnter2D(Collider2D item)
    { 
        Destroy(gameObject); 
    }
}
    