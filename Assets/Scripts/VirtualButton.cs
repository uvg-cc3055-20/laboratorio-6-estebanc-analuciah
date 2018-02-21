using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {

	private VirtualButtonBehaviour virtualBtn;
	public Animator birdAnim;
	// Use this for initialization
	void Start () {
		virtualBtn = GetComponent<VirtualButtonBehaviour>(); 
		virtualBtn.RegisterEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed(VirtualButtonBehaviour b) {
		birdAnim.SetTrigger("sing");
	}

	public void OnButtonReleased(VirtualButtonBehaviour b) {
	}
}
