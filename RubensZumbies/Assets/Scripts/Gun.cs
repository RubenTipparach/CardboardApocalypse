using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    [SerializeField]
    GameObject bullette;

    [SerializeField]
    Transform spawnPoint;

    [SerializeField]
    GameObject spawnEffect;

    [SerializeField]
    MagnetSensor sensor;

	// Use this for initialization
	void Start () {
        sensor.OnCardboardTrigger += Shoot;

    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
	}

    public void Shoot()
    {
        GameObject.Instantiate(bullette, spawnPoint.position, spawnPoint.rotation);
        if (spawnEffect)
        {
            GameObject.Instantiate(spawnEffect, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
