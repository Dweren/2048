using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager Instance;

    public Color[] CellColors;

    [Space(10)]
    public Color PointsDarkColor;
    public Color PointsLightColor;

    [Space(10)]
    public Color WinColor;
    public Color LoseColor;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
}
