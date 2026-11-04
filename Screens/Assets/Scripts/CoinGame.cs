using UnityEngine;
using UnityEngine.UI;

// A tiny "game": tap the button, earn a coin, the box spins faster.
public class CoinGame : MonoBehaviour
{
    [SerializeField] Text coinText;
    [SerializeField] RectTransform spinner;
    [SerializeField] float degreesPerCoin = 30f;

    int coins;

    void Start() => UpdateText();

    public void AddCoin()
    {
        coins++;
        UpdateText();
    }

    void Update()
    {
        if (spinner != null)
            spinner.Rotate(0f, 0f, -(90f + coins * degreesPerCoin) * Time.deltaTime);
    }

    void UpdateText()
    {
        if (coinText != null)
            coinText.text = $"Coins: {coins}";
    }
}
