using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.tinyjams.tjlib.Runtime.Movement
{
    public class MoveBetweenPositions : MonoBehaviour
    {
        [Serializable]
        public enum MovementType
        {
            Linear
        }

        [SerializeField] private List<Transform> targetPositions;
        [SerializeField] private MovementType movementType = MovementType.Linear;
        [SerializeField] private bool startOnStartEvent = true;

        [Header("Linear"), SerializeField] private float linearSpeed = 10.0f;
        [SerializeField] private float waitAtArrival = 0.0f;

        private int currentTargetIdx;
        private Coroutine currentRoutine;

        public bool IsMovingActive => this.currentRoutine != null;

        public void StartMovement()
        {
            if (this.currentRoutine != null)
            {
                this.StopCoroutine(this.currentRoutine);
            }

            switch (this.movementType)
            {
                case MovementType.Linear:
                    this.currentRoutine = this.StartCoroutine(this.MoveLinear());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void StopMovement()
        {
            if (this.currentRoutine != null)
            {
                this.StopCoroutine(this.currentRoutine);
                this.currentRoutine = null;
            }
        }

        private void Start()
        {
            if (this.startOnStartEvent)
            {
                this.StartMovement();
            }
        }

        private IEnumerator MoveLinear()
        {
            if (this.targetPositions.Count <= 0) yield break; // dont run if no positions set
            while (true)
            {
                var currentTarget = this.targetPositions[this.currentTargetIdx];

                this.transform.position = Vector3.MoveTowards(this.transform.position, currentTarget.position,
                    this.linearSpeed * Time.deltaTime);

                if (Vector3.Distance(this.transform.position, currentTarget.transform.position) < 0.01f)
                {
                    this.currentTargetIdx++;
                    this.currentTargetIdx %= this.targetPositions.Count;
                    yield return new WaitForSeconds(this.waitAtArrival);
                }
                else
                {
                    yield return null;
                }
            }
        }
    }
}