using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace com.tinyjams.tjlib.Runtime.UI
{
    [RequireComponent(typeof(Image))]
    public class FadeScreen : MonoBehaviour
    {
        [SerializeField] private float startAlpha = 0.0f;
        [SerializeField] private float fadeInSpeed = 1.0f;
        [SerializeField] private float fadeOutSpeed = 1.0f;

        private Image img;

        private void Awake()
        {
            this.img = this.GetComponent<Image>();
        }

        public void Start()
        {
            var imgColor = this.img.color;
            imgColor.a = this.startAlpha;
            this.img.color = imgColor;
        }

        public void FadeIn()
        {
            this.StopAllCoroutines();
            this.StartCoroutine(this.FadeRoutine(0.0f, this.fadeInSpeed));
        }

        private IEnumerator FadeRoutine(float target, float fadeSpeed)
        {
            var imgColor = this.img.color;
            var alpha = imgColor.a;
            while (Mathf.Abs(alpha - target) > 0.001f)
            {
                alpha = Mathf.MoveTowards(alpha, target, fadeSpeed * Time.deltaTime);
                imgColor.a = alpha;
                this.img.color = imgColor;
                yield return 0;
            }
        }

        public void FadeOut()
        {
            this.StopAllCoroutines();
            this.StartCoroutine(this.FadeRoutine(1.0f, this.fadeOutSpeed));
        }
    }
}