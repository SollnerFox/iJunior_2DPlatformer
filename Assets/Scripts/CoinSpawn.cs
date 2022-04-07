using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CoinSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _spawnedCoin;
    private readonly BoxCollider2D _boxCollider2D;
    void Awake()
    {
        _boxCollider2D.isTrigger = true;
    }


}
