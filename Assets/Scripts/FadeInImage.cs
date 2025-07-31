using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeInImage : MonoBehaviour
{
    public float fadeDuration = 2f;

    public CanvasGroup canvasGroup;
    private float timer = 0f;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;//Start transparent
    }

    private void Update()
    {
        if(canvasGroup.alpha < 1f) 
        {
            timer += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(timer / fadeDuration);
        }
    }
}
