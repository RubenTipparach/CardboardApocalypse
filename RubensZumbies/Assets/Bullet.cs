using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField]
    float speed;

    [SerializeField]
    float lifeTime;

    float timePassed;

    [SerializeField]
    GameObject splatter;

    [SerializeField]
    GameObject splatter2;

    [SerializeField]
    GameObject explosion;

    [SerializeField]
    float bulletColliderDetect = 1;

    [SerializeField]
    float damage;

    [SerializeField]
    float damageOffset;

	// Use this for initialization
	void Start () {
        timePassed = 0;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(timePassed >= lifeTime)
        {
            Destroy(gameObject);
        }

        timePassed += Time.deltaTime;
	}

    void FixedUpdate()
    {
        Collider[] colliders = (Physics.OverlapSphere(transform.position, bulletColliderDetect));

        if(colliders.Length > 0)
        {
            foreach(Collider c in colliders)
            {
                Debug.Log("Hits: " + c.gameObject.name);
            }

            MonsterAlpha monster1 = colliders[0].transform.GetComponent<MonsterAlpha>();

            if(monster1)
            {
                monster1.Health -= damage;
            }

            Destroy(gameObject);
            GameObject.Instantiate(splatter,transform.position, transform.rotation * Quaternion.Euler(0,90,0));
        }

    }
}
