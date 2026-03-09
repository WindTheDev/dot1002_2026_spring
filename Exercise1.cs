public string[] resourceNames = { "Gold", "Crystal", "Food", "Wood", "Iron" };
public Text[] resourceTexts;

void UpdateResourceText(int resourceIndex, int amount) {
    if (resourceIndex >= 0 && resourceIndex < resourceTexts.Length) {
        resourceTexts[resourceIndex].text = "Amount: " + amount.ToString();
    }
}