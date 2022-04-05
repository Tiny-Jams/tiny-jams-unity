using UnityEngine;

namespace TinyJams.P01_TinyShooter.Runtime
{
    public class MoveInDirection : MonoBehaviour
    {
        [SerializeField] private Vector3 direction;
        [SerializeField] private float speed;

        private void Awake()
        {
            this.direction.Normalize();
        }

        private void Update()
        {
            var translation = this.direction * this.speed * Time.deltaTime;
            this.transform.Translate(translation);
        }
    }
}