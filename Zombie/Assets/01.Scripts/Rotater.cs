using UnityEngine;

public class Rotater : MonoBehaviour
{
    //�ʴ� ȸ�� �ӵ�
    public float rotationSpeed = 60f;
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}