using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifebarUI : MonoBehaviour
{
    [SerializeField] Image lifebarFill;
    [SerializeField] LifeController heath;
    [SerializeField] float speedDecay = 6;

    float lifePercent;

    public float LifeToAnimation => heath.Life; // permite o acesso pra o AnimationController
    public float LifePercent => lifePercent; // permite o acesso pra o AnimationController

    void LateUpdate() {
        lifePercent = heath.Life / heath.MaxLife; // transforma a vida em uma porcentagem pra o fillAmount
        lifebarFill.fillAmount = Mathf.Lerp(lifebarFill.fillAmount, lifePercent, Time.deltaTime * speedDecay);

    }
}
