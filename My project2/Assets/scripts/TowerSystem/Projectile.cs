using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody rd;

    public float moveSpeed;
    public float damagedAmount;
    private bool hasDamaged;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        rd.velocity = transform.forward * moveSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" && !hasDamaged)
        {
            other.GetComponent<EnermyHealthController>().TakeDamage((int)damagedAmount);
            hasDamaged = true;
        }

        Destroy(gameObject);
    }

}
