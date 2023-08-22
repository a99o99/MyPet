using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrinningState : IState
{
    MyPet mypet;
    string speak;

    public GrinningState(MyPet mypet)
    {
        this.mypet = mypet;
    }

    public void Feed()
    {
        speak = "냠냠!!";
        mypet.SetText(speak);
    }

    public void Walk()
    {
        mypet.SetState(mypet.happyState);
        speak = "좋아!!!";
        mypet.SetText(speak);
    }

    public void Pet()
    {
        mypet.SetState(mypet.happyState);
        speak = "ㅎㅎ";
        mypet.SetText(speak);
    }

    public void PlayBall()
    {
        speak = "멍멍!!";
        mypet.SetText(speak);
    }

}
