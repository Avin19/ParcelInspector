using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ScreenFader : Singleton<ScreenFader>
{
    [SerializeField] private Image blackPanel;
    [SerializeField] private float fadeDuration = 0.5f;

    private bool isFading;

    protected override void Awake()
    {
        base.Awake();

        Color c = blackPanel.color;
        c.a = 0f;
        blackPanel.color = c;

        blackPanel.raycastTarget = false;
    }

    public IEnumerator FadeOut()
    {
        if (isFading)
            yield break;

        yield return Fade(0f, 1f);
    }

    public IEnumerator FadeIn()
    {
        if (isFading)
            yield break;

        yield return Fade(1f, 0f);
    }

    private IEnumerator Fade(float from, float to)
    {
        isFading = true;

        float timer = 0f;

        Color color = blackPanel.color;
        color.a = from;
        blackPanel.color = color;

        blackPanel.raycastTarget = true;

        while (timer < fadeDuration)
        {
            timer += Time.unscaledDeltaTime;

            color.a = Mathf.Lerp(from, to, timer / fadeDuration);
            blackPanel.color = color;

            yield return null;
        }

        color.a = to;
        blackPanel.color = color;

        blackPanel.raycastTarget = to > 0.95f;

        isFading = false;
    }
}
