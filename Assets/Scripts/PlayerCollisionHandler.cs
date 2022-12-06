using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(Player))]
    [RequireComponent(typeof(BricksHolder))]
    public class PlayerCollisionHandler : MonoBehaviour
    {
        private Player _player;
        private BricksHolder _bricksHolder;

        private void Start()
        {
            _player = GetComponent<Player>();
            _bricksHolder = GetComponent<BricksHolder>();
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
            _bricksHolder.Add(brick);
            brick.gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}