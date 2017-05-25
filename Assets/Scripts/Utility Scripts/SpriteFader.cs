/*
 *
 *  Happy
 *  by Toni Steyskal, 2016-2017
 * 
 */

using System.Collections;

using UnityEngine;

namespace Happy
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class SpriteFader : MonoBehaviour
    {
        public enum FadeType
        {
            FadeIn,
            FadeOut
        }

        public bool FadeOnAwake = true;
        public FadeType Type = FadeType.FadeIn;
        [Positive]
        public float Duration = 1.0f;

        private SpriteRenderer _spriteRenderer;

        void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();

            if (FadeOnAwake)
                StartCoroutine(Fade(Type, Duration));
        }

        public IEnumerator Fade(FadeType type, float duration)
        {
            WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();

            Color spriteColor = _spriteRenderer.color;
            spriteColor.a = type == FadeType.FadeIn ? 0.0f : 1.0f; ;
            _spriteRenderer.color = spriteColor;

            float requiredAlpha = type == FadeType.FadeIn ? 1.0f : 0.0f;
            float fadeInterval = (requiredAlpha - _spriteRenderer.color.a) / (duration / Time.fixedDeltaTime);

            bool shouldFade = true;

            while (shouldFade)
            {
                spriteColor.a += fadeInterval;
                _spriteRenderer.color = spriteColor;

                shouldFade = type == FadeType.FadeIn ? _spriteRenderer.color.a < requiredAlpha : _spriteRenderer.color.a > requiredAlpha;

                yield return waitForFixedUpdate;
            }
        }
    }
}
