using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(Player))]
    public class PlayerCollisionHandler : MonoBehaviour
    {
        private Player _player;

        private void Start()
        {
            _player = GetComponent<Player>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Brick brick))
            {
                if (brick.Color == _player.Color)
                    CollectBricks(brick);
            }
        }

        private void CollectBricks(Brick brick)
        {
            Destroy(brick.gameObject);
        }
    }
}