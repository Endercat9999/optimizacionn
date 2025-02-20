using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolEnemigo : MonoBehaviour

{
    public GameObject prefab; // Prefab del monstruo
    public int poolSize = 10; // Tamano del pool

    private List<GameObject> pool;

    void Start()
    {
        pool = new List<GameObject>();

        // Inicializar el pool
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false); // Desactivar el objeto al inicio
            pool.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                return obj; // Retornar un objeto inactivo
            }
        }
        return null; // Si no hay objetos disponibles
    }
}

