using UnityEngine;

public class StockingTrigger : MonoBehaviour
{
    private Stocking stocking;

    private void OnTriggerEnter(Collider other)
    {
        if(stocking == null)
        stocking = other.gameObject.GetComponent<Stocking>();
        
        stocking.canStockItems = true;
    }

    private void OnTriggerExit(Collider other)
    {
        stocking.canStockItems = false;
    }
}
