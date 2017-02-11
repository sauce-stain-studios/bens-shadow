using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorSwitch : MonoBehaviour, ISwitch {

  public GameObject activatableObject;

	void Start () {
	}

  void Update () {

  }

  public void Switch() {
    if (activatableObject != null) {
      activatableObject.GetComponent<IActivatable>().Activate();
    }
  }

}
