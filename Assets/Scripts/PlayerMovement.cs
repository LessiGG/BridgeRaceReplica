using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private FixedJoystick _joystick;

        private Animator _animator;
        private Rigidbody _rigidbody;
    
        private static readonly int IsRunning = Animator.StringToHash("isRunning");

        private void Start()
        {
            _animator = GetComponent<Animator>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            _rigidbody.velocity = new Vector3(_joystick.Horizontal * _speed, _rigidbody.velocity.y, _joystick.Vertical * _speed);

            if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
            {
                transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
                _animator.SetBool(IsRunning, true);
            }
            else
            {
                _animator.SetBool(IsRunning, false);
            }
        }
    }
}