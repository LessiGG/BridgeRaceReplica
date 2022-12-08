using UnityEngine;

namespace Scripts
{
    public class BricksSpawner : MonoBehaviour
    {
        [SerializeField] private Brick _prefab;
        [SerializeField] private Transform _container;
        [SerializeField] private float _gridSpacingOffsetX = 1f;
        [SerializeField] private float _gridSpacingOffsetZ = .5f;
        [SerializeField] private int _lenght;
        [SerializeField] private int _width;

        private const float _brickYPosition = 0.1f;
        
        private void Start()
        {
            SpawnByGrid();
        }

        private void SpawnByGrid()
        {
            for (int x = 0; x < _lenght; x++)
            {
                for (int z = 0; z < _width; z++)
                {
                    var spawnPosition = new Vector3(x * _gridSpacingOffsetX, _brickYPosition, z * _gridSpacingOffsetZ);
                    Instantiate(_prefab, spawnPosition, Quaternion.identity, _container);
                }
            }
        }
    }
}