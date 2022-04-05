using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TinyJams.P01_TinyShooter.Runtime
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 10.0f;
        
        private P01_Input input;
        private float currentDirection = 0.0f;

        private void Awake()
        {
            this.input = new P01_Input();
        }

        private void OnEnable()
        {
            this.input.Default.Enable();
        }

        private void Start()
        {
            this.input.Default.Fire.started += ctx => this.GetComponent<SpawnPrefab>().SpawnAtGameObjectPosition();
            this.input.Default.Left.started += ctx => this.currentDirection = -1.0f;
            this.input.Default.Right.started += ctx => this.currentDirection = 1.0f;
            this.input.Default.Left.canceled += ctx => this.currentDirection = 0.0f;
            this.input.Default.Right.canceled += ctx => this.currentDirection = 0.0f;
        }

        private void Update()
        {
            this.Move(this.currentDirection);
        }

        private void Move(float direction)
        {
            this.transform.Translate(Vector3.right * direction * Time.deltaTime * this.moveSpeed);
        }
    }
}