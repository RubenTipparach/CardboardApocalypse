using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUpParticle : MonoBehaviour {

    [SerializeField]
    float lifeTime;

    float timePassed;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (timePassed >= lifeTime)
        {
            Destroy(gameObject);
        }

        timePassed += Time.deltaTime;
    }
}
