 
    using UnityEngine; 
    using UnityEngine.EventSystems;

    public class BulletSpawn : MonoBehaviour 
    {
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private Transform _startPoint;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            Instantiate(_bulletPrefab, _startPoint.position, transform.rotation);
        }
    }
