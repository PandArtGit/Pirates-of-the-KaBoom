using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifebarUI : MonoBehaviour
{
    [SerializeField] Image lifebarFill;
    [SerializeField] LifeController heath;
    [SerializeField] float speedDecay = 6;

    void LateUpdate() {
        float lifePercent = heath.Life / heath.MaxLife;
        lifebarFill.fillAmount = Mathf.Lerp(lifebarFill.fillAmount, lifePercent, Time.deltaTime * speedDecay);  
    }
}
