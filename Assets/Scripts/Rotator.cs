using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _speed, 0);
    }
}
