using UnityEngine;

namespace Assets.Scripts
{
    public class RandomColor2D : MonoBehaviour
    {
        private SpriteRenderer sp;
        [SerializeField]
        private Color minHue;
        [SerializeField]
        private Color maxHue;

        void Start()
        {
            sp = GetComponent<SpriteRenderer>();
        }

        public void ChangeColor()
        {
            sp.color = Random.ColorHSV();
        }
    }
}