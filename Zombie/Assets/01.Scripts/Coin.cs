using UnityEngine;

public class Coin : MonoBehaviour, Iitem
{
    public int score = 200;//������ ����

    public void Use(GameObject target)
    {
        //���ӸŴ����� ������ ���� �߰�
        GameManager.instance.Addscore(score);
        //���Ǿ����Ƿ� �ڽ��� �ı�
        Destroy(gameObject);
    }
}