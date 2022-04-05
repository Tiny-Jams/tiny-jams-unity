using UnityEngine;

namespace com.tinyjams.tjlib.Runtime.Movement
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