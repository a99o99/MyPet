using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyPet : MonoBehaviour
{
    public Image myPetIcon;
    public TextMeshProUGUI textUI;
    public List<Sprite> ListiconSprite;

    public IState angryState {get; set;}
    public IState grinningState {get; set;}
    public IState happyState {get; set;}
    public IState sadState {get; set;}

    public IState currentState;
    
    void Start()
    {
        Init();
    }

    public void Init()
    {
        angryState = new AngryState(this);
        grinningState = new GrinningState(this);
        happyState = new HappyState(this);
        sadState = new SadState(this);

        currentState = happyState;
        SetImage(currentState);
    }

    // 밥주기
    public void Feed()
    {
        currentState.Feed();
        SetImage(currentState);
    }

    // 공놀이
    public void PlayBall()
    {
        currentState.PlayBall();
        SetImage(currentState);

    }

    // 쓰다듬기
    public void Pet()
    {
        currentState.Pet();
        SetImage(currentState);

    }
    
    // 산책
    public void Walk()
    {
        currentState.Walk();        
        SetImage(currentState);

    }

    // 상태 변경
    public void SetState(IState state)
    {
        this.currentState = state;
    }

    public void SetImage(IState state)
    {
        switch (state)
        {
            case AngryState : 
                myPetIcon.sprite = ListiconSprite[0];
                break;
                
            case GrinningState : 
                myPetIcon.sprite = ListiconSprite[1];
                break;

            case HappyState : 
                myPetIcon.sprite = ListiconSprite[2];
                break;

            case SadState : 
                myPetIcon.sprite = ListiconSprite[3];
                break;   
        }
    }

    public void SetText(string speak)
    {
        textUI.text = speak;
    }

}
