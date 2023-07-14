using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] private GameObject BlastVisual;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,1.6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(BlastVisual,transform.position,Quaternion.identity);
        Ui.instance.AddCount();
    }
}
