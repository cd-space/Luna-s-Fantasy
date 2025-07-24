using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.GetComponent<LunaController>()?.ChangeHeath(1);
        LunaController lunaController = collision.GetComponent<LunaController>();
        if (lunaController != null)
        {
            if(lunaController.CurrentHealth >= lunaController.MaxHealth)
            {
                return;
            };
            lunaController.ChangeHeath(1);
            Destroy(gameObject); // ����ҩˮ����
        }
    }

    ////��������ʱ��������
    //private void OnTriggerStay2D(Collider2D collision)
    //{
        
    //}


    ////����������ʱ����
    //private void OnTriggerExit2D(Collider2D collision)
    //{
        
    //}
}
