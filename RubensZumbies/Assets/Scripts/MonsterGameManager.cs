using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterGameManager : MonoBehaviour {

    [SerializeField]
    MonsterSpawner[] spawners;

    public int enemyDeaths = 0;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}

    public void Spawn()
    {
        int randomRoll = Random.Range(0, spawners.Length);

        enemyDeaths++;

        if (enemyDeaths < 10)
        {
            spawners[randomRoll].TriggerSpawn(1);
        }
        else if (enemyDeaths < 20)
        {
            spawners[randomRoll].TriggerSpawn(2);
        }
        else if (enemyDeaths < 30)
        {
            spawners[randomRoll].TriggerSpawn(3);
        }
        //foreach (MonsterSpawner spawn in spawners)
        //{
        //    spawn.TriggerSpawn(1);
        //}
    }
}

public class MonsterWaves
{

}