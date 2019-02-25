using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "Settings", order = 1)]
public class Settings : ScriptableObject
{
    [SerializeField]
    public float Volume;
    
    public void SetVolume(float vol)
    {
        Volume = vol;
    }
}
