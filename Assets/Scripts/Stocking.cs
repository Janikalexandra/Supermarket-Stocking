using UnityEngine;

public class Stocking : MonoBehaviour
{
    public bool canStockItems;
    
    Ray ray;
    RaycastHit hit;

    public Shelf shelf;

    private void Update()
    {
        if(canStockItems)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Vector2 mousePos = Input.mousePosition;
                ray = Camera.main.ScreenPointToRay(mousePos);
                
                // gameobject must have tag 'Shelf'
                if(Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Shelf")
                {
                    // get the reference for shelf script
                    shelf = hit.transform.gameObject.GetComponent<Shelf>();

                    // stock the shelfs if they are empty                  
                    shelf.StockShelfs();                   
                }
            }
        }
    }
}
