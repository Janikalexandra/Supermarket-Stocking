using UnityEngine;

public class GroceryItem : MonoBehaviour
{
    public bool isOnShelf;
    public Transform placeOnShelf;
    public float speed;

    private void Update()
    {
        if(!isOnShelf)
        {
            if (placeOnShelf != null)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, placeOnShelf.position, speed * Time.deltaTime);

                if (this.transform.position == placeOnShelf.position)
                {
                    isOnShelf = true;
                }
            }
        }      
    }
}
