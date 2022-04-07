using System.Collections;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _spawnCoin;
    void Start()
    {
        StartCoroutine(SpawnCoin());
    }

    private IEnumerator SpawnCoin ()
    {
        while (true)
        {
            float xCoordinate = Random.Range(6f, 24f);
            GameObject spawnedCoin = Instantiate(_spawnCoin, new Vector3(xCoordinate, -3.5f, -0.5f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
