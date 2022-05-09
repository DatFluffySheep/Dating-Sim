using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Fungus;

public class VarHandler : MonoBehaviour
{
    public Flowchart flowchart1;

    public void LoadVars()
    {
        int Day = PlayerPrefs.GetInt("DayPref"); //gets playerPref data from memory and temporarily stores it in int Day
        flowchart1.SetIntegerVariable("Day", Day); //sets the fungus flowchart variable to the data that was saved in the memory

        string TimeOfDay = PlayerPrefs.GetString("TimeOfDayPref");
        flowchart1.SetStringVariable("TimeOfDay", TimeOfDay);

        int DaysRemain = PlayerPrefs.GetInt("DaysRemainPref"); 
        flowchart1.SetIntegerVariable("DaysRemain", DaysRemain);

        int GGLove = PlayerPrefs.GetInt("GGLovePref");
        flowchart1.SetIntegerVariable("GGLove", GGLove);

        int CFLove = PlayerPrefs.GetInt("CFLovePref");
        flowchart1.SetIntegerVariable("CFLove", CFLove);

        int FELove = PlayerPrefs.GetInt("FELovePref");
        flowchart1.SetIntegerVariable("FELove", FELove);

    }

    public void SaveVars()
    {
        int Day = flowchart1.GetIntegerVariable("Day"); //sets a temporary variable to equal the fungus flowchart variable
        PlayerPrefs.SetInt("DayPref", Day); //save fungus flowchart variable to a playerPref

        string TimeOfDay = flowchart1.GetStringVariable("TimeOfDay");
        PlayerPrefs.SetString("TimeOfDayPref", TimeOfDay);

        int DaysRemain = flowchart1.GetIntegerVariable("DaysRemain");
        PlayerPrefs.SetInt("DaysRemainPref", DaysRemain);

        int GGLove = flowchart1.GetIntegerVariable("GGLove");
        PlayerPrefs.SetInt("GGLovePref", GGLove);

        int CFLove = flowchart1.GetIntegerVariable("CFLove");
        PlayerPrefs.SetInt("CFLovePref", CFLove);

        int FELove = flowchart1.GetIntegerVariable("FELove");
        PlayerPrefs.SetInt("FELovePref", FELove);

        PlayerPrefs.Save(); //save all above set prefs
        Debug.Log("saved " + gameObject.name);
    }
}
