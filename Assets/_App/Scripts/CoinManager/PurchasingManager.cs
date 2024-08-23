using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasingManager : MonoBehaviour
{
   public void OnPressDown(int i)
   {
      switch (i)
      {
         case 1:
            GameManager.Apple += 10;
             IAPManager.Instance.BuyProductID(IAPKey.PACK1);
            break;
         case 2:
            GameManager.Apple += 30;
            IAPManager.Instance.BuyProductID(IAPKey.PACK2);
            break;
         case 3:
            GameManager.Apple += 50;
            
            IAPManager.Instance.BuyProductID(IAPKey.PACK3);
            break;
         case 4:
            GameManager.Apple += 100;
            IAPManager.Instance.BuyProductID(IAPKey.PACK4);
            break;
      }
   }

   public void Sub(int i)
   {
      GameDataManager.Instance.playerData.SubDiamond(i);
   }
}
