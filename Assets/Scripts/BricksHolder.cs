using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Scripts
{
    public class BricksHolder : MonoBehaviour
    {
        [SerializeField] private Transform _bricksHolderPosition;
        [SerializeField] private float _yIncreasePosition;
        [SerializeField] private float _brickAddingSpeed = 0.2f;

        private readonly List<Brick> _bricks = new List<Brick>();

        public void Add(Brick collectedBrick)
        {
            _bricks.Add(collectedBrick);
            PlayMoveBrickAnimation(collectedBrick);
        }

        private void PlayMoveBrickAnimation(Brick brick)
        {
            var brickPosition = new Vector3(0, (_bricks.Count - 1) * _yIncreasePosition, 0);

            brick.transform.parent = _bricksHolderPosition.transform;
            brick.transform.DOLocalMove(brickPosition, _brickAddingSpeed);
            brick.transform.rotation = _bricksHolderPosition.transform.rotation;
        }
    }
}