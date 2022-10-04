[System.Serializable]
public class InventoryItem
{
    public ItemData data;
    public int stackSize;

    public InventoryItem(ItemData itemData)
    {
        data = itemData;
    }
    public void AddStack()
    {
        stackSize++;
    }
    public void RemoveFromStack()
    {
        stackSize--;
    }

}
