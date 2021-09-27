using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private GameObject towerToBuild;
    public GameObject defaultTowerPrefab;
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;
    }

    void Start()
    {
        towerToBuild = defaultTowerPrefab;    
    }

    public GameObject GetTowerToBuild()
    {
        return towerToBuild;
    }
}
