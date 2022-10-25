using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPack : MonoBehaviour, Iitem
{
    public int ammo = 30;
    public void Use(GameObject target)
    {
        //target에 탄알을 추가하는 처리
        Debug.Log("탄알이 증가했다 : " + ammo);
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
