using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCheesecake : MonoBehaviour
{
    [SerializeField] private GameObject cheesecake;
    void Start()
    {
        Instantiate(cheesecake);
    }

    void spawnObject()
    {
        //TODO Setup a cheesecake factory
        Instantiate(cheesecake);
    }
}
