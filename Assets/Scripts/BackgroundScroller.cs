using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.1f; // The speed at which the background will scroll
    private new Renderer renderer; // The renderer component of the background

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>(); // Get the renderer component of the background
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the amount by which to offset the texture based on time and scroll speed
        float offset = Time.time * scrollSpeed;

        // Set the offset of the texture based on the calculated amount
        renderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}