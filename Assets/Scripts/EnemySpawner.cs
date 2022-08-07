using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        Instantiate(player, new Vector3(Random.Range(-23f, 23f), 2.5f, Random.Range(-23f, 23f)), Quaternion.identity);

        Instantiate(player, new Vector3(Random.Range(-23f, 23f), 2.5f, Random.Range(-23f, 23f)), Quaternion.identity);

        Instantiate(player, new Vector3(Random.Range(-23f, 23f), 2.5f, Random.Range(-23f, 23f)), Quaternion.identity);

        Instantiate(player, new Vector3(Random.Range(-23f, 23f), 2.5f, Random.Range(-23f, 23f)), Quaternion.identity);

        Instantiate(player, new Vector3(Random.Range(-23f, 23f), 2.5f, Random.Range(-23f, 23f)), Quaternion.identity);
    }
}
