 
using UnityEngine;

public class SpawnerEnemy: MonoBehaviour
{ 
    [SerializeField] private GameObject _enemyPrefab;
    private void Start()
    {
        InvokeRepeating("Spawn",1f,1f);
        LoadDataEnemyPosition();
    }
    private void Spawn() 
    {
        float randomY = Random.Range(-0.6f, 0.3f);
        Vector3 newPosition = new Vector3 ( 2, randomY, 0);
        Instantiate(_enemyPrefab, newPosition, transform.rotation); 
    }

    public void LoadDataEnemyPosition()
    {
        if (MainManager.Instance != null)
        {
            for (int i = 0; i < MainManager.Instance.enemyPosition.Count; i++)
            {
                Instantiate(_enemyPrefab, MainManager.Instance.enemyPosition[i], transform.rotation);
            }
        }      
    }
}
