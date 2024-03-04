
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerEnemy: MonoBehaviour
{ 
    [SerializeField] private GameObject _enemyPrefab;

    private void Start()
    {
        InvokeRepeating("Spawn",1f,1f);
    }
    private void Spawn() => Instantiate(_enemyPrefab, transform.position, transform.rotation);
}
