using System.Collections.Generic;
public class GroceryIsle
{
    public List<FoodItem> FoodItemsList;
    public string IsleName { get; set; }
    public float IsleNumber { get; set; }

    public GroceryIsle (string IsleName, float IsleNumber, List<FoodItem> FoodItemsList)
    {
        this.IsleName = IsleName;

        this.IsleNumber = IsleNumber;
        
        this.FoodItemsList = FoodItemsList;
    }
}