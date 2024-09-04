using UnityEngine;
using Random = UnityEngine.Random;

public class map : MonoBehaviour
{
    [SerializeField] private GameObject[] land;
    [SerializeField] private GameObject[] backGround;
    private Vector3 landPos = new Vector3(11f, -5.13f, 0);
    private Vector3 backGroundPos = new Vector3(14, 0,0);
    private float spawnTime = 0.3f;
    private float backGroundSpawnTime = 0.3f;

    private void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <=0)
        {
            float range = Random.Range(10f, 12f);
            int landMap = Random.Range(0, 3);
            spawnTime = 0.5f;
            Instantiate(land[landMap], landPos, land[landMap].transform.rotation);
            landPos += new Vector3(range, 0, 0);
        }

        backGroundSpawnTime -= Time.deltaTime;
        if (backGroundSpawnTime <= 0)
        {
            backGroundSpawnTime = 0.3f;
            Instantiate(backGround[0], backGroundPos, backGround[0].transform.rotation);
            backGroundPos += new Vector3(7, 0, 0);
        }
    }
}
