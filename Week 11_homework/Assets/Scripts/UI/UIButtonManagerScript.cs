using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonManagerScript : MonoBehaviour
{
    //set several event's public variable, including the tiete, input field and submit button.
    public GameObject nameTitle;
    public GameObject nameField;
    public GameObject nameSubmit;

    public GameObject ageTitle;
    public GameObject ageField;
    public GameObject ageSubmit;

    public GameObject dateTitle;
    public GameObject dateField;
    public GameObject dateSubmit;

    public GameObject weatherTitle;
    public GameObject weatherField;
    public GameObject weatherSubmit;

    public GameObject foodTitle;
    public GameObject foodField;
    public GameObject foodSubmit;

    public GameObject petNameTitle;
    public GameObject petNameField;
    public GameObject petNameSubmit;

    public GameObject animalTitle;
    public GameObject animalField;
    public GameObject animalSubmit;

    public GameObject birthTitle;
    public GameObject birthField;
    public GameObject birthSubmit;

    public GameObject AdjTitle;
    public GameObject AdjField;
    public GameObject AdjSubmit;

    public GameObject finalDiary;

    public void TurnOnAgeButtons(){
        
        nameTitle.SetActive(false);
        nameField.SetActive(false);
        nameSubmit.SetActive(false);
        //Turns off the nameTitle, nameField and submit button

        ageTitle.SetActive(true);
        ageField.SetActive(true);
        ageSubmit.SetActive(true);
        //Turns on the ageTitle, ageField and submit button
    }

    public void TurnOnDateButtons()
    {
        ageTitle.SetActive(false);
        ageField.SetActive(false);
        ageSubmit.SetActive(false);
        //Turns off the ageTitle, ageField and submit button

        dateTitle.SetActive(true);
        dateField.SetActive(true);
        dateSubmit.SetActive(true);
        //Turns on the dateTitle, dateField and submit button
    }

    public void TurnOnWeatherButtons()
    {
        dateTitle.SetActive(false);
        dateField.SetActive(false);
        dateSubmit.SetActive(false);
        //Turns off the dateTitle, dateField and submit button

        weatherTitle.SetActive(true);
        weatherField.SetActive(true);
        weatherSubmit.SetActive(true);
        //Turns on the weatherTitle, weatherField and submit button
    }

    public void TurnOnFoodButtons()
    {
        weatherTitle.SetActive(false);
        weatherField.SetActive(false);
        weatherSubmit.SetActive(false);
        //Turns off the weatherTitle, weatherField and submit button

        foodTitle.SetActive(true);
        foodField.SetActive(true);
        foodSubmit.SetActive(true);
        //Turns on the foodTitle, foodField and submit button
    }

    public void TurnOnPetNameButtons()
    {
        foodTitle.SetActive(false);
        foodField.SetActive(false);
        foodSubmit.SetActive(false);
        //Turns off the foodTitle, foodField and submit button

        petNameTitle.SetActive(true);
        petNameField.SetActive(true);
        petNameSubmit.SetActive(true);
        //Turns on the petNameTitle, petNameField and submit button
    }

    public void TurnOnAnimalButtons()
    {
        petNameTitle.SetActive(false);
        petNameField.SetActive(false);
        petNameSubmit.SetActive(false);
        //Turns off the foodTitle, foodField and submit button

        animalTitle.SetActive(true);
        animalField.SetActive(true);
        animalSubmit.SetActive(true);
        //Turns on the petNameTitle, petNameField and submit button
    }

    public void TurnOnBirthButtons()
    {
        animalTitle.SetActive(false);
        animalField.SetActive(false);
        animalSubmit.SetActive(false);
        //Turns off the animalTitle, animalField and submit button

        birthTitle.SetActive(true);
        birthField.SetActive(true);
        birthSubmit.SetActive(true);
        //Turns on the birthTitle, birthField and submit button
    }

    public void TurnOnAdjButtons()
    {
        birthTitle.SetActive(false);
        birthField.SetActive(false);
        birthSubmit.SetActive(false);
        //Turns off the birthTitle, birthField and submit button

        AdjTitle.SetActive(true);
        AdjField.SetActive(true);
        AdjSubmit.SetActive(true);
        //Turns on the AdjTitle, AdjField and submit button
    }

    public void TurnOffAdjButtons()
    {
        AdjTitle.SetActive(false);
        AdjField.SetActive(false);
        AdjSubmit.SetActive(false);
        //Turns off the AdjTitle, AdjField and submit button

        finalDiary.SetActive(true);
        //Turn on the final diary

    }
}
