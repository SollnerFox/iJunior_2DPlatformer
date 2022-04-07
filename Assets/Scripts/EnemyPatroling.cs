using UnityEngine;

public class EnemyPatroling : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;

    private int _currentWaypointIndex = 0;
    public float _speed = 2f;
    //private SpriteRenderer _sprite;

    private void Start() 
    {
        //_sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Transform currentWaypoint = _waypoints[_currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, _speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, currentWaypoint.position) <= 0f)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Length;
            transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }

}