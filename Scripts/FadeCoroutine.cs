using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeCoroutine : MonoBehaviour
{
    [SerializeField] private Renderer renderer;
    [Range(0f, 0.05f)]
    [SerializeField] private float fadeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine("Fade");
        }
    }

    IEnumerator Fade()
    {
        for (float ft = 1f; ft >= 0; ft -= fadeSpeed)
        {
            Debug.Log("F");
            Color c = renderer.material.color;
            c.a = ft;
            renderer.material.color = c;
            yield return null;
        }
    }
}
