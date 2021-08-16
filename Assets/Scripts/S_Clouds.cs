using System.Collections;
using UnityEngine;

public class S_Clouds : MonoBehaviour
{
    //
    //

    public GameObject[] Clouds = new GameObject[6];
    public Transform[] PosCreate = new Transform[8];

    public float TimeToCreate;



    void Start()
    {
        StartCoroutine(StartTime());
    }

    IEnumerator StartTime()
    {
        yield return new WaitForSeconds(TimeToCreate);
        if (GameObject.FindGameObjectWithTag("Player") != null)
            CreateCloud();
    }

    void CreateCloud()
    {
        int NumCloud = Random.Range(0, 6);
        int NumPos = Random.Range(0, 8);


        GameObject Cloud = Instantiate(Clouds[NumCloud], PosCreate[NumPos].position, PosCreate[NumPos].rotation);
        int a = Random.Range(0, 2);
        if (a == 0)
            print("0");//Cloud.GetComponent<SpriteRenderer>().flipX = true;
        else
            print("1"); //Cloud.GetComponent<SpriteRenderer>().flipX = true;

        StartCoroutine(StartTime());
    }
}
