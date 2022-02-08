using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//SCRIPT 'CustomObserverEventHandler' PERSONALIZADO
public class CustomObserverEventHandler : DefaultObserverEventHandler
{
    //variable para la imagen
    public Image detectionImage;
    //colores caracteristicos
    [Space]
    public Color colorFound;
    public Color colorLost;
    //SOBREESCRITURA DEL METODO PADRE
    protected override void OnTrackingFound()
    {
        //llamada al metodo del padre
        base.OnTrackingFound();
        Debug.Log($"<color=green><b>FOUND!</b></color>");
        detectionImage.color = colorFound; //cambio de color
    }
    //SOBREESCRITURA DEL METODO PADRE
    protected override void OnTrackingLost()
    {
        //llamada al metodo del padre
        base.OnTrackingLost();
        Debug.Log($"<color=red><b>LOST!</b></color>");
        detectionImage.color = colorLost; //cambio de color
    }
}
