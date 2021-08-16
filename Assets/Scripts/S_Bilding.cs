using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Bilding : MonoBehaviour
{
    //
    //

    public GameObject[] PosCreate = new GameObject[4];

    public GameObject Bild_Down;
    public GameObject bild_Up;

    public float TimeToCreate = 2;

    void Start()
    {
        StartCoroutine(StartTime());
    }

    IEnumerator StartTime()
    {
        yield return new WaitForSeconds(TimeToCreate);
        if (GameObject.FindGameObjectWithTag("Player") != null)
            CreateBild();
    }

    void CreateBild()
    {
        int NumPos = Random.Range(0, 4);

        GameObject Bild = Instantiate(Bild_Down, PosCreate[NumPos].transform.position, PosCreate[NumPos].transform.rotation);
        GameObject Bild_upper = Instantiate(bild_Up, Bild_Down.transform.position, Bild_Down.transform.rotation);
        Bild_upper.transform.parent = Bild.transform;

        float Pos = Random.Range(23f, 30f);
        Bild_upper.transform.position = new Vector3(Bild.transform.position.x, Bild.transform.position.y + Pos, 0);
        StartCoroutine(StartTime());
    }

    //
    public void Respawn()
    {
        SceneManager.LoadScene(0);
    }

}
