using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPack : MonoBehaviour, Iitem
{
    public int ammo = 30;
    public void Use(GameObject target)
    {
        //target�� ź���� �߰��ϴ� ó��
        Debug.Log("ź���� �����ߴ� : " + ammo);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}