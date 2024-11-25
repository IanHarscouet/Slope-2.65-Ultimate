using System.Collections;
using UnityEngine;

public class ObstacleInfo : MonoBehaviour
{
    public GameObject Débutposition;
    public GameObject Finposition;
    public void Start()
    {
        StartCoroutine(TimerPrefab());
    }
    public IEnumerator TimerPrefab()
    {
        yield return new WaitForSeconds(25f);
        Destroy(this.gameObject);
    }
}
