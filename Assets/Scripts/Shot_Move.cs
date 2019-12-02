using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot_Move : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public Rigidbody2D rb;
    public GameObject enemyDeath;

    
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, lifetime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
        }
    }
}
