using UnityEngine;

namespace Scripts
{
    public class MaterialSetter : MonoBehaviour
    {
        [SerializeField] private Material _material;

        private void Awake()
        {
            SetMaterial();
        }

        private void SetMaterial()
        {
            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                if (transform.GetChild(i).TryGetComponent(out SkinnedMeshRenderer meshRenderer))
                {
                    meshRenderer.material = _material;
                }
            }
        }

        public Material GetMaterial()
        {
            return _material;
        }
    }
}