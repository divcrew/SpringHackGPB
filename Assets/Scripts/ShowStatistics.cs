using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ShowStatistics : MonoBehaviour
{
    public GameObject text;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    private System.Random random = new System.Random();
    private int bugsFixed { get; set; }
    private int bugsCreated { get; set; }
    private int tasksCompleted { get; set; }
    private int allTasks { get; set; }
    private int unitTestsCount { get; set; }

    // Use this for initialization 
    void Start()
    {
        bugsCreated = random.Next(10);
        bugsFixed = random.Next(bugsCreated);
        allTasks = random.Next(5);
        tasksCompleted = random.Next(allTasks);
        unitTestsCount = allTasks * random.Next(5);
    }

    // Update is called once per frame 
    void Update()
    {
        text.GetComponent<Text>().text = "Создано багов: " + bugsCreated;
        text1.GetComponent<Text>().text = "Починено багов: " + bugsFixed;
        text2.GetComponent<Text>().text = "Количество заданий: " + allTasks;
        text3.GetComponent<Text>().text = "Выполнено заданий: " + tasksCompleted;
        text4.GetComponent<Text>().text = "Проведено юнит-тестов: " + unitTestsCount;
    }
}