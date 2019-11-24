using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diaryScript : MonoBehaviour
{
    //get the text player input
    public Text diaryText;
    public Text nameInput;
    public Text ageInput; 
    public Text dateInput;
    public Text weatherInput;
    public Text foodInput; 
    public Text petInput;
    public Text animalInput;
    public Text birthInput;
    public Text adjInput;

    //public string diary;
    //public string nameString;
    //public string ageString;


    //Gets the events submitted by the player and updates the text to the diary
    void Update()
    {
        //nameString = nameInput.text;
        //string names = nameInput.text; //split the name to just get the first name
        //string age = ageInput.text;

        //diaryText.text = diary.Replace(nameString, names);
        //diaryText.text = diary.Replace(ageString, age);

        diaryText.text = "Today is "+ dateInput.text + ". It's a " + weatherInput.text + " day. My uncle's pet " + animalInput.text + " " + nameInput.text
            + " is sick because it eats too many " + foodInput.text + "s . He decides to take " + nameInput.text + " to visit veterinarian " +
            petInput.text + " who works in " + birthInput.text + ". Unfortunately "+ petInput.text + " is too busy today. He is treating " +
            ageInput.text + " sick " + animalInput.text + "s which are irritable to the " + weatherInput.text + " weather. What a "
            + adjInput.text + " day!";//combine all the text input by player to a diary
}
}
