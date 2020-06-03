using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnTime = 1f;
    [SerializeField] float maxSpawnTime = 5f;
    [SerializeField] Attacker[] attackersToSpawn = null;

    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        var attackerToSpawn = attackersToSpawn[Random.Range(0, attackersToSpawn.Length)];

        Attacker newAttaker = Instantiate(attackerToSpawn, transform.position, Quaternion.identity) as Attacker;
        newAttaker.transform.parent = transform;    
    }
}
