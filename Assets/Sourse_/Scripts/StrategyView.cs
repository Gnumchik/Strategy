using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrategyView : MonoBehaviour
{
    [SerializeField] private Button aboveBtn;
    [SerializeField] private Button belowBtn;
    [SerializeField] private Button strongBtn;
    [SerializeField] private Image aboveBtnImage;
    [SerializeField] private Image belowBtnImage;
    [SerializeField] private Image strongBtnImage;

    public Button AboveBtn => aboveBtn;
    public Button BelowBtn => belowBtn;
    public Button StrongBtn => strongBtn;

    public Image AboveBtnImage => aboveBtnImage;
    public Image BelowBtnImage => belowBtnImage;
    public Image StrongBtnImage => strongBtnImage;

}
