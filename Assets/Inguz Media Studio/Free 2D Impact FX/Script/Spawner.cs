using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private GameObject Bat;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(CallSpawner());
    }
    private IEnumerator CallSpawner() 
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            Vector3 pos = new Vector3(Random.Range(-7.05f, 7.11f), 5.92f, 0f);
            Instantiate(Bat,pos,Quaternion.identity);
        }
    }
}
