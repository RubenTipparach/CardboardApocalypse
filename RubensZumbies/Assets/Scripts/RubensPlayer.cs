using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RubensPlayer : MonoBehaviour {

    [SerializeField]
    float sphereRadius = .5f;

    [SerializeField]
    float playerInitialHealth;

    [SerializeField]
    Text HealthCounter;

    [SerializeField]
    GameObject bloodSplatter;

    [SerializeField]
    GameObject deathSquence;

    [SerializeField]
    GameObject gun;

    public float currentHealth = 0;

    [SerializeField]
    GameObject gameManager;

	// Use this for initialization
	void Start ()
    {
        currentHealth = playerInitialHealth;

        HealthCounter.text = string.Format("Health: {0}", currentHealth);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, sphereRadius);
        foreach(Collider c in colliders)
        {
            MonsterAlpha ma = c.transform.GetComponent<MonsterAlpha>();
            if(ma)
            {
                //monster should decide damage.
                SubtractHealth(10);
                ma.KillMonster();
            }
        }

    }

    bool dead = false;

    void SubtractHealth(float amount)
    {
        if (currentHealth <= 0 && !dead)
        {
            HealthCounter.text = string.Format("You DIED, you are LAME!!!!!");
            gun.SetActive(false);
            GameObject.Instantiate(deathSquence, transform.position, Quaternion.identity);
            gameManager.SetActive(false);
            dead = true;
        }
        else if (!dead) {

            GameObject.Instantiate(bloodSplatter, transform.position, transform.rotation * Quaternion.Euler(0, -90, 0));
            currentHealth -= amount;
            HealthCounter.text = string.Format("Health: {0}", currentHealth);
        }
    }
}
