using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehavior : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f;
    public float movementSpeed = 5f;
    public int totalCoins = 0;
    public int obtainedSpecialCoins = 0;
    public int obtainedCoins = 0;
    public int valorCoinItem = 1;
    public int valorSpecialCoinItem = 5;
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI normalCoinsText;
    public TextMeshProUGUI specialCoinsText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        Vector3 movement = new Vector3();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        rb.AddForce(movement * Time.deltaTime * movementSpeed, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoinItem"))
        {
            totalCoins = totalCoins + valorCoinItem;
            obtainedCoins = obtainedCoins + 1;
        }
        else if (other.CompareTag("SpecialCoinItem"))
        {
            totalCoins = totalCoins + valorSpecialCoinItem;
            obtainedSpecialCoins = obtainedSpecialCoins + 1;
        }

        if (other.tag.Contains("Coin"))
        {
            coinsText.text = "Coins: " + totalCoins.ToString();
            normalCoinsText.text = "Normal Coins: " + obtainedCoins.ToString();
            specialCoinsText.text = "Special Coins: " + obtainedSpecialCoins.ToString();
            other.gameObject.SetActive(false);
        }
    }
}
