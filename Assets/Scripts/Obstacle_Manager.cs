using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Obstacle_Manager : MonoBehaviour
{
    public GameObject[] Prefabs;
    public LevelDataBase LevelDataBase;
    public GameData gameData;
   

    public void CreationPrefab(Vector3 positionSpawn)
    {
        float[] levelProbas = LevelDataBase.levels[gameData.buttonIndex].probaniveau;

        if(levelProbas.Length != Prefabs.Length)
        {
            Debug.LogError("ayaya");
        }

        int prefabIndex = Choose(levelProbas);

       
        GameObject PrefabsRandom = Prefabs[ prefabIndex];
        Vector3 débutpostition = PrefabsRandom.GetComponent<ObstacleInfo>().Débutposition.transform.position;
        GameObject myvar = Instantiate(PrefabsRandom,positionSpawn - débutpostition,Quaternion.identity);        
    }


    int Choose(float[] probs)
    {

        float total = 0;

        foreach (float elem in probs)
        {
            total += elem;
        }

        float randomPoint = Random.value * total;

        for (int i = 0; i < probs.Length; i++)
        {
            if (randomPoint < probs[i])
            {
                return i;
            }
            else
            {
                randomPoint -= probs[i];
            }
        }
        return probs.Length - 1;
    }

}
