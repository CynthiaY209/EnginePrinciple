using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : Singleton<ArrowManager>
{

    private Transform arrowSpawnTransform;

    void Awake()
    {
        GetArrowSpawnTransform();
    }

    void GetArrowSpawnTransform()
    {
        arrowSpawnTransform = HeroManager.Instance.heroBehaviour.projectileSpawnTransform;
    }

    public void SpawnArrow()
    {

        GameObject arrow = ObjectPooler.SharedInstance.GetPooledObject("Arrow");


        if(arrow != null)
        {
            arrow.SetActive(true);
            arrow.transform.position = arrowSpawnTransform.position;
            arrow.transform.rotation = arrowSpawnTransform.rotation;
            arrow.GetComponent<ArrowBehaviour>().BeginMoving();
        }
    }

}
