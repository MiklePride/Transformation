using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        transform.localPosition += Vector3.forward * Time.deltaTime;
    }
}
