using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalorieUI : MonoBehaviour
{
    void Start()
    {
        GameObject CalorieUI= GameObject.Find("CalorieUI");
        CalorieUI InCalorieUI = CalorieUI.GetComponent<CalorieUI>();
        GetComponent<TextMesh>().text = InCalorieUI.totalCalorie.ToString();
    }
}