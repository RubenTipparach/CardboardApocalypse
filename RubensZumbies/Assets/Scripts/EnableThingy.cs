using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableThingy : MonoBehaviour {

    [SerializeField]
    GameObject thingy;

	// Use this for initialization
	void Start () {
       // GetComponent<MagnetSensor>().OnCardboardTrigger += TriggerButton;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TriggerButton()
    {
        if(!thingy.activeInHierarchy)
        {
            thingy.SetActive(true);
        }
        else
        {
            thingy.SetActive(false);
        }
    }
}
