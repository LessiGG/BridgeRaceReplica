using UnityEngine;
using Random = System.Random;

namespace Scripts
{
    public class Brick : MonoBehaviour
    {
        [SerializeField] private Material[] _materials;
        
        public Color Color { get; private set; }
        
        private readonly Random _random = new Random();
        private Material _material;

        private void Start()
        {
            _material = GetComponent<MeshRenderer>().material;
            SetRandomColor();
        }

        private void SetRandomColor()
        {
            var id = _random.Next(_materials.Length);
            _material.color = _materials[id].color;
            Color = _material.color;
        }
    }
}