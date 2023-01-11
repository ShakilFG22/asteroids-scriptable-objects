using System.Collections;
using System.Collections.Generic;
using Asteroids;
using UnityEngine;

[CreateAssetMenu(fileName = "MySO")]
public class MySO : ScriptableObject
{
    //TODO assign a reference to the amount of time to spawn asteroids

    [SerializeField] private float num;

    private AsteroidSpawner _asteroidSpawner;



    public void ChangeValue() => _asteroidSpawner._maxSpawnTime = num;
    







}
