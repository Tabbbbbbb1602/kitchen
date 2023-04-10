using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player){
        if(!HasKitchenObject()){
            //There is no KitchenObject here
            if(player.HasKitchenObject()){
                //Player is carrying something
                //Người chơi đang mang theo một cái gì đó
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
        }
    }
    
}
