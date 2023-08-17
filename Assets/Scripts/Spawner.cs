using UnityEngine;

namespace Assets.Scripts
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject instance = null;

        public void SpawnGameObject()
        {
            Instantiate(instance, transform.position, transform.rotation);
        }
    }
}