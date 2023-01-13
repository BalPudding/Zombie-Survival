using UnityEngine;

public class Rotater : MonoBehaviour
{
    //초당 회전 속도
    public float rotationSpeed = 60f;
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
