using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text money;

    Player player;
    float moneyValue;

    public float MoneyValue
    { 
        get { return moneyValue; } 
        set { moneyValue = value; } 
    }
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();

        //PlayerPrefs.DeleteKey("money");
        moneyValue = PlayerPrefs.GetFloat("money");
    }

    // Update is called once per frame
    void Update()
    {
        if(player.isDisabled() == false)
        {
            moneyValue += Time.deltaTime / 4f;
            
        }

        money.text = Mathf.Round(moneyValue).ToString();
        PlayerPrefs.SetFloat("money", moneyValue);
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("money", moneyValue);
    }
}
