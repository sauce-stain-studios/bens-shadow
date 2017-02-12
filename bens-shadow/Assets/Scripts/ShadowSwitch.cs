using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ShadowSwitch : MonoBehaviour,ISwitch {
    
    public GameController gc;
    private bool _switchOn;
    public Animator animator;

    void Start()
    {
        gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        animator = GetComponent<Animator>();
         _switchOn = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (gc.getCurrentDimension() == GameController.Dimension.Real) 
        {
           _switchOn = true;     
        }
        if (gc.getCurrentDimension() == GameController.Dimension.Shadow) 
        {
            _switchOn = false; 
        }
        animator.SetBool("_switchOn", _switchOn);
    }
   

    public void Switch()
    {
        Debug.Log("fgsdfgsdfg");
        if (gc.getCurrentDimension() == GameController.Dimension.Real)
        {
            gc.setDimensionShadow();
    
            Debug.Log("s");
        }
       else if (gc.getCurrentDimension() == GameController.Dimension.Shadow)
        {
            gc.setDimensionReal();
            Debug.Log("d");
        }
    
    }
}
