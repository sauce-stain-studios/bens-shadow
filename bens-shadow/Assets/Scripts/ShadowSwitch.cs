using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ShadowSwitch : MonoBehaviour,ISwitch {

    public Animator animator;
    public GameController gc;
    private bool _switchOn;
    private bool visited = false;


    void Start()
    {
        gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        animator = GetComponent<Animator>();
         _switchOn = false;
    }

    // Update is called once per frame
    void FixedUpdate() {
      if (gc.getCurrentDimension() == GameController.Dimension.Real) {
        _switchOn = true;
      } else {
        _switchOn = false;
      }
      animator.SetBool("_switchOn", _switchOn);
    }

    void OnTriggerEnter2D(Collider2D col) {
  		if (!visited) {
  			visited = true;
  			Switch();
  		}
  	}

    void OnTriggerExit2D(Collider2D col) {
      visited = false;
    }

    public void Switch() {
      if (gc.getCurrentDimension() == GameController.Dimension.Real) {
          gc.setDimensionShadow();
      } else if (gc.getCurrentDimension() == GameController.Dimension.Shadow) {
          gc.setDimensionReal();
      }
    }
}
