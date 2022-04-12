using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TinyJams.P03_SpriteAnimations
{
    public class ChickenController : MonoBehaviour
    {
        private ChickenInput input;
        private Vector2 movement;
        private Animator animator;

        private static readonly int Vertical = Animator.StringToHash("Vertical");
        private static readonly int Horizontal = Animator.StringToHash("Horizontal");
        private static readonly int IsWalking = Animator.StringToHash("isWalking");

        private void Awake()
        {
            this.animator = this.GetComponent<Animator>();
            this.input = new ChickenInput();
        }

        private void Start()
        {
            this.input.General.Enable();
            this.input.General.Movement.performed += OnMovementOnperformed;
            this.input.General.Movement.canceled += ctx => this.animator.SetBool(IsWalking, false);
            this.input.General.Movement.started += ctx => this.animator.SetBool(IsWalking, true);
        }

        private void OnMovementOnperformed(InputAction.CallbackContext ctx)
        {
            this.movement = ctx.ReadValue<Vector2>();

            this.animator.SetFloat(Horizontal, this.movement.x);
            this.animator.SetFloat(Vertical, this.movement.y);
        }
    }
}