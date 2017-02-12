using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightIntensity : MonoBehaviour {

    public GameController gc;
    public float bright = 1.0F;
    public float dark = 0.5F;


    // Use this for initialization
    void Start()
    {
        gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        GetComponent<Light>().intensity = dark;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gc.getCurrentDimension() == GameController.Dimension.Real)
        {
            GetComponent<Light>().intensity = dark;
        }
        else
        {
            GetComponent<Light>().intensity = bright;
        }
    }
}
