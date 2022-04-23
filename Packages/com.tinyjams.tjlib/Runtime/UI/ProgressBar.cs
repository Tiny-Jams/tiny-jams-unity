using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace com.tinyjams.tjlib.Runtime.UI
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField, Range(0.0f, 1.0f)] private float percentage;
        [SerializeField] private RectTransform backgroundRect;
        [SerializeField] private RectTransform fillRect;
        [SerializeField] private Image fillImage;
        [SerializeField] private float width = 500.0f;

        [SerializeField] public UnityEvent<float> onValueChanged;

        public void SetPercentage(float p)
        {
            this.percentage = Mathf.Clamp(this.percentage, 0.0f, 1.0f);
            this.UpdateVisuals();
            this.onValueChanged.Invoke(this.percentage);
        }

        private void OnValidate()
        {
            this.fillImage.fillMethod = Image.FillMethod.Horizontal;
            this.UpdateVisuals();
        }

        private void UpdateVisuals()
        {
            if (this.fillImage)
            {
                this.fillImage.fillAmount = this.percentage;
            }
        }
    }
}