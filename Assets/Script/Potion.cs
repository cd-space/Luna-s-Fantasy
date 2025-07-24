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

    ////触发器内时持续调用
    //private void OnTriggerStay2D(Collider2D collision)
    //{
        
    //}


    ////触发器出来时调用
    //private void OnTriggerExit2D(Collider2D collision)
    //{
        
    //}
}
