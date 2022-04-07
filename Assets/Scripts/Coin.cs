using System.Collections;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Coin : MonoBehaviour
{   
    [SerializeField] private GameObject _collectedAnimationPrefab;
    private int coinValue = 1; 
    private BoxCollider2D _boxCollider2D;
    private void Start() 
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
        _boxCollider2D.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            Destroy(gameObject);
            GameObject collectedClone = Instantiate(_collectedAnimationPrefab, transform.position, transform.rotation);
            Destroy(collectedClone, 1f);
            CoinCounter.instance.ChangeScore(coinValue);
        }    
    }
    
}
