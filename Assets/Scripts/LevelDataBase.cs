using UnityEngine;

[CreateAssetMenu(fileName = "LevelDataBase", menuName = "Scriptable Objects/LevelDataBase")]
public class LevelDataBase : ScriptableObject
{
    public LevelSO[] levels;
}
