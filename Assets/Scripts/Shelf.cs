using UnityEngine;

public class Shelf : MonoBehaviour
{
    public Transform[] shelfItemSpaces;

    public Transform itemHolder;
    public GameObject currentItem;

    public void StockShelfs()
    {
        for(int i = 0; i < 4; i++)
        {
            if (shelfItemSpaces[i].transform.childCount >= 1)
                continue;
            
            Debug.Log(shelfItemSpaces[i].gameObject.name);
            currentItem = Instantiate(GroceryItemManager.Instance.currentGroceryItem, 
                itemHolder.transform.position, Quaternion.identity, shelfItemSpaces[i]);
            currentItem.GetComponent<GroceryItem>().placeOnShelf = shelfItemSpaces[i];
            break;
        }        
    }
}
