using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(MaterialSetter))]
    public class Player : MonoBehaviour
    {
        public Color Color { get; private set; }
        
        private MaterialSetter _materialSetter;
        
        private void Start()
        {
            _materialSetter = GetComponent<MaterialSetter>();
            Color = _materialSetter.GetMaterial().color;
        }
    }
}