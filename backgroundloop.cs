using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class backgroundloop : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundrenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backgroundrenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime , 0);
    }
}
