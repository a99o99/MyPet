using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyState : IState
{
    MyPet mypet;
    string speak;

    public HappyState(MyPet mypet)
    {
        this.mypet = mypet;
    }

    public void Feed()
    {
        mypet.SetState(mypet.grinningState);
        speak = "배불러!";
        mypet.SetText(speak);
    }

    public void Walk()
    {
        mypet.SetState(mypet.sadState);
        speak = "피곤해...";
        mypet.SetText(speak);
    }

    public void Pet()
    {
        speak = "S2S2";
        mypet.SetText(speak);
    }

    public void PlayBall()
    {
        speak = "왈왈ㅇㄹ왕ㅇ왈!!!!";
        mypet.SetText(speak);
    }
}
