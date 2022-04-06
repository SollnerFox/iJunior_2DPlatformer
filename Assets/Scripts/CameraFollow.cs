using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float _followSpeed;
    [SerializeField] private float _xOffset;
    [SerializeField] private float _yOffset;

    public Transform target; 

    void Update()
    {
        Vector3 newPos = new Vector3 (target.position.x, 0f, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, _followSpeed * Time.deltaTime);        
    }
}
