using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBase : GameUnit
{
    [SerializeField] private float speed = 10f;
    private float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }
    public void OnInit(float damage)
    {
        this.damage = damage;
    }
    public void OnDespawn()
    {
        //Destroy(gameObject);
        SimplePool.Despawn(this);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            OnDespawn();
        }
    }
}
