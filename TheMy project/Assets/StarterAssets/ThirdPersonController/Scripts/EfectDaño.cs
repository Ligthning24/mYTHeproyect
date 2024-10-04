using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EfectDaño : MonoBehaviour
{

    public RawImage bloodEffectImage;

    private float r;
    private float g;
    private float b;
    private float a;



    void Start()
    {
        r = bloodEffectImage.color.r;
        g = bloodEffectImage.color.g;
        b = bloodEffectImage.color.b;
        a = bloodEffectImage.color.a;

    }


    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            a += 0.05f;

        }
        if (Input.GetKey(KeyCode.E))
        {
            a -= 0.05f;
        }

        a -= 0.005f;

        a = Mathf.Clamp(a, 0, 1f);
        ChangeColor();
    }

    private void ChangeColor()
    {
        Color c = new Color(r, g, b, a);
        bloodEffectImage.color = c;
    }
}
