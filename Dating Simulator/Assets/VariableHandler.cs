using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class VariableHandler : MonoBehaviour
{
    public Flowchart flowchart1;

    int Day;
    string TimeOfDay;
    int DaysRemain;
    int GGLove;
    int CFLove;
    int FELove;

    void setVars ()
    {
        Day = flowchart1.GetIntegerVariable("Day");
        TimeOfDay = flowchart1.GetStringVariable("TimeOfDay");
        DaysRemain = flowchart1.GetIntegerVariable("DaysRemain");
        GGLove = flowchart1.GetIntegerVariable("GGLove");
        CFLove = flowchart1.GetIntegerVariable("CFLove");
        FELove = flowchart1.GetIntegerVariable("FELove");
    }

    void getVars()
    {
        flowchart1.SetIntegerVariable("Day", Day);
        flowchart1.SetStringVariable("TimeOfDay", TimeOfDay);
        flowchart1.SetIntegerVariable("DaysRemain", DaysRemain);
        flowchart1.SetIntegerVariable("GGLove", GGLove);
        flowchart1.SetIntegerVariable("CFLove", CFLove);
        flowchart1.SetIntegerVariable("FELove", FELove);
    }
}
