using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGame_Manager : MonoBehaviour
{
    // variable int
    public int hunger;
    public int sanity;
    // variable textmesh pro
    public TextMeshProUGUI hungerTextValue, 
                           sanityTextValue,
                           storyTextValue;
    // variable string
    public string start;
    // declare game object
    public GameObject level1_Choices;

    // Start is called before the first frame update
    void Start()
    {
        hunger = 10;
        sanity = 100;
        start = "can you see me?";
    }

    // Update is called once per frame
    void Update()
    {
        // textmeshpro.variable = value int
        hungerTextValue.text = hunger.ToString();
        sanityTextValue.text = sanity.ToString();
        storyTextValue.text = start;
    }

    public void Yes()
    {
        sanity -= 10;
        hunger += 5;
        start = "Good";
        level1_Choices.SetActive(false);
    }
    public void No()
    {
        sanity -= 10;
        hunger += 80;
        start = "Oh ?";
        level1_Choices.SetActive(false);
    }
    public void DontAnswer()
    {
        sanity -= 80;
        hunger += 40;
        start = "How boring";
        level1_Choices.SetActive(false);
    }
}
