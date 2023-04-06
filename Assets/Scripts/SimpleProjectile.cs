using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleProjectile : MonoBehaviour
{
    Rigidbody rb;
    public float projectileSpeed = 50;
    public float lifetime = 5;
    public int scorePoint = 1;
    public CombatController owner;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = gameObject.transform.forward * projectileSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        CombatController cc = collision.collider.GetComponentInParent<CombatController>();
        if(cc)
        {
            CombatManager.instance.AddDeath(scorePoint);
            cc.Reset();
            owner.Reset();
        }
        Destroy(gameObject);
    }
}
