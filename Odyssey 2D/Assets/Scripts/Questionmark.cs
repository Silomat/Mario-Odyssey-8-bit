using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questionmark : MonoBehaviour
{
    public GameObject ItemToSpawn;
    public Transform spawnPoint;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("PlayerHead"))
        {
            Instantiate(ItemToSpawn, spawnPoint);
        }
    }
}
