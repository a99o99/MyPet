using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class MyPet_Enum : MonoBehaviour
{
    public enum State
    {
        Grinning,
        Happy,
        Angry,
        Sad
    }

    // UI 관련
    public Image myPetIcon;
    public TextMeshProUGUI textUI;
    public List<Sprite> ListiconSprite;

    public State currentState;
    

    public void MakeSound()
    {
        switch(currentState)
        {
            case State.Grinning:
                myPetIcon.sprite = ListiconSprite[1];
                textUI.text = "멍!!";
                break;

            case State.Happy:
                myPetIcon.sprite = ListiconSprite[2];
                textUI.text = "왈왈!!";
                break;

            case State.Angry:
                myPetIcon.sprite = ListiconSprite[0];
                textUI.text = "으르렁!!";
                break;

            case State.Sad:
                myPetIcon.sprite = ListiconSprite[3];
                textUI.text = "끼잉...";
                break;
        }       
    }

}
