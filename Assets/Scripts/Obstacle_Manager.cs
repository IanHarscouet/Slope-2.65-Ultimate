using System.Collections;
using NUnit.Framework;
using UnityEngine;

public class Obstacle_Manager : MonoBehaviour
{
    public GameObject[] Prefabs;
   

    public void CreationPrefab(Vector3 positionSpawn)
    {
        GameObject PrefabsRandom = Prefabs[ Random.Range(0, Prefabs.Length)];
        Vector3 débutpostition = PrefabsRandom.GetComponent<ObstacleInfo>().Débutposition.transform.position;
        GameObject myvar = Instantiate(PrefabsRandom,positionSpawn - débutpostition,Quaternion.identity);        
    }

}
