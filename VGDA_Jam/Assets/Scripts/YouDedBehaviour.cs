using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouDedBehaviour : MonoBehaviour {

    public float fadeInSpeed;

    private MeshRenderer textMeshRenderer;
    private SpriteRenderer bgMeshRenderer;
    private Color ogTextColor;
    private Color ogBgColor;

    private AudioSource dedSoundSource;

    private void Start() {
        dedSoundSource = GetComponent<AudioSource>();

        textMeshRenderer = GetComponent<MeshRenderer>();
        ogTextColor = textMeshRenderer.material.color;
        textMeshRenderer.material.color = new Color(ogTextColor.r, ogTextColor.g, ogTextColor.b, 0);

        bgMeshRenderer = GetComponentInChildren<SpriteRenderer>();
        ogBgColor = bgMeshRenderer.material.color;
        bgMeshRenderer.material.color = new Color(ogBgColor.r, ogBgColor.g, ogBgColor.b, 0);
    }

    public void YouDedAnimation() {
        dedSoundSource.Play();
        StartCoroutine(YouDedFade());
    }

    private IEnumerator YouDedFade() {
        float tempA = 0;
        while(tempA < 1) {
            tempA += fadeInSpeed;
            textMeshRenderer.material.color = new Color(ogTextColor.r, ogTextColor.g, ogTextColor.b, tempA);
            bgMeshRenderer.material.color = new Color(ogBgColor.r, ogBgColor.g, ogBgColor.b, tempA);
            yield return new WaitForEndOfFrame();
        }
    }
}
