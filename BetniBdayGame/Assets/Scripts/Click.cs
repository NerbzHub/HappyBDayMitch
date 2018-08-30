using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public Camera mainCam;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                CapsuleCollider cc = hit.collider as CapsuleCollider;
                if(cc != null)
                {
                    Destroy(cc.gameObject);
                    CounterNTimer.Counter++;
                }
            }
        }
	}
}
