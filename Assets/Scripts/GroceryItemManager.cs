using UnityEngine;

public class GroceryItemManager : MonoBehaviour
{
    public GameObject currentGroceryItem;

    public GameObject[] groceryItems;

    public static GroceryItemManager Instance;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentGroceryItem = groceryItems[3];
    }
}
