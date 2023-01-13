using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
   //������ ���ӿ��� ���θ� �����ϴ� ���� �Ŵ���
{
    public static GameManager instance
        //�̱��� ���ٿ� ������Ƽ
    {
        get
        {
            //���� �̱��� ������ ���� ������Ʈ�� �Ҵ���� �ʾҴٸ�
            if(m_instance == null)
            {
                //������ GameManager ������Ʈ�� ã�Ƽ� �Ҵ�
                m_instance = FindObjectOfType<GameManager>();
            }
            //�̱��� ������Ʈ ��ȯ
            return m_instance;
        }
    }
    private static GameManager m_instance; // �̱����� �Ҵ�� static ����
    int score = 0;//���� ���� ����
    public bool isGameover { get; private set; } //���� ���� ����
    private void Awake()
    {
        // ���� �̱��� ������Ʈ�� �� �ٸ� GameManager ������Ʈ�� �ִٸ�
        if(instance !=this)
        {
            //�ڽ��� �ı�
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //�÷��̾� ĳ������ ��� �̺�Ʈ �߻� �� ���ӿ���
        FindObjectOfType<PlayerHealth>().onDeath += Endgame;
    }

    public void Addscore(int newScore)
    {
        //������ �߰��ϰ� UI ����
        //���ӿ����� �ƴ� ���¿����� ���� �߰� ����
        if (!isGameover)
        {
            //���� �߰�
            score += newScore;
            //���� UI �ؽ�Ʈ ����
            UIManager.instance.UpdateScore(score);
        }
    }
    public void Endgame()
    {
        //���� ���� ó��
        //���� ���� ���¸� ������ ����
        //���� ���� UI Ȱ��ȭ
        isGameover = true;
        UIManager.instance.SetActiveGameoverUI(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
