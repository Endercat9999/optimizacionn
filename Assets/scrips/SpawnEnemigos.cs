using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{

    [SerializeField] private Transform _EnemybulletSpawn;
    [SerializeField] private int _ammoType = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        GameObject Enemybollet = PoolManager.Instance.GetPooledObjects(_ammoType, _EnemybulletSpawn.position, _EnemybulletSpawn.rotation);

        if (Enemybollet != null)
        {
            Enemybollet.SetActive(true);
        }
        else
        {
            Debug.Log("Pool demasiado pequeno");
        }
    }

    
    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(5f); 
        }
    }
}
