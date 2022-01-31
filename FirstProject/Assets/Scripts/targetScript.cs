using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetScript : MonoBehaviour
{
    [SerializeField] float hitPrize = 0;
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cycleGenerator());
        //GameObject newCycle = Instantiate(go, new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), 0), Quaternion.identity);
    }

    void Update()
    {

    }

    IEnumerator cycleGenerator()
    {
        while (true)
        {
            
            GameObject newCycle = Instantiate(go, new Vector3(Random.Range(282, 299), Random.Range(-4, 4), 0), Quaternion.identity);
            newCycle.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            Destroy(newCycle.gameObject, 10);
            yield return new WaitForSeconds(1);

        }
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        hitPrize += 20;
        Debug.Log("You have earned new score!, your currnet score is equal to = "+ hitPrize);
    }


}
