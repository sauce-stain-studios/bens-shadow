using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Director;


public class LightSwitch : MonoBehaviour {
    
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
}
