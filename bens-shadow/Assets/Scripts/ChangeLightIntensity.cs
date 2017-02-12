using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightIntensity : MonoBehaviour {
    public float duration = 0.5F;
    public Color realColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    public Color shadowColor  = new Color(0.85f, 0.4f, 0.9f, 0.5f);

    Light lightValue;
    GameController gc;

    void Start() {
        gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        lightValue = GetComponent<Light>();
        lightValue.color = Color.white;
    }

    void Update() {
        Color color = realColor;
        if (gc.getCurrentDimension() == GameController.Dimension.Shadow) {
          color = shadowColor;
        }
        lightValue.color = Color.Lerp(lightValue.color, color, 1f * Time.deltaTime);
    }
}
