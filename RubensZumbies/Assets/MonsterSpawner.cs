using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour {

    [SerializeField]
    GameObject monsterObjects;

    [SerializeField]
    GameObject monsterObjectsLvl2;

    [SerializeField]
    GameObject monsterObjectsLvl3;

    // These are for the random factor in case more than one are spawned at once.
    [SerializeField]
    float xOffset;

    [SerializeField]
    float yOffset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TriggerSpawn(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Vector3 rand1 = new Vector3(
                  transform.position.x + Random.Range(-xOffset, xOffset),
                  transform.position.y,
                transform.position.z + Random.Range(-yOffset, yOffset));
            // otherwise we need a little bit of random....
            if (amount == 1)
            {
                GameObject.Instantiate(monsterObjects, rand1, Quaternion.identity);
            }
            if(amount ==2)
            {
                Vector3 rand2 = new Vector3(
                  transform.position.x + Random.Range(-xOffset, xOffset),
                  transform.position.y,
                transform.position.z + Random.Range(-yOffset, yOffset));

                GameObject.Instantiate(monsterObjects, rand1, Quaternion.identity);
                GameObject.Instantiate(monsterObjectsLvl2, rand2, Quaternion.identity);

            }
            if (amount == 3)
            {
                Vector3 rand2 = new Vector3(
                  transform.position.x + Random.Range(-xOffset, xOffset),
                  transform.position.y,
                transform.position.z + Random.Range(-yOffset, yOffset));

                Vector3 rand3 = new Vector3(
                  transform.position.x + Random.Range(-xOffset, xOffset),
                  transform.position.y,
                transform.position.z + Random.Range(-yOffset, yOffset));

                GameObject.Instantiate(monsterObjects, rand1, Quaternion.identity);
                GameObject.Instantiate(monsterObjectsLvl2, rand2, Quaternion.identity);
                GameObject.Instantiate(monsterObjectsLvl3, rand3, Quaternion.identity);
            }
        }
    }
}
