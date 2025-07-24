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
            Destroy(gameObject); // 销毁药水对象
        }
    }

    ////人物待在触发器时
    //private void OnTriggerStay2D(Collider2D collision)
    //{
        
    //}


    ////人物离开触发器时
    //private void OnTriggerExit2D(Collider2D collision)
    //{
        
    //}
}
