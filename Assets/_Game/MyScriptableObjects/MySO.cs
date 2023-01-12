using System;
using System.Collections;
using System.Collections.Generic;
using Asteroids;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "MySO")]
public class MySO : ScriptableObject
{
    //TODO assign a reference to the maximum amount of time to spawn asteroids

    [Header("Config Asteroid Spawner:")]
    public float _minSpawnTime; //1
    public float _maxSpawnTime; //4
    public int _minAmount; //1
    public int _maxAmount; //2
    
    [Header("Config Asteroid:")]
    public float _minForce; //2
    public float _maxForce; //6
    public float _minSize; //0.2
    public float _maxSize; //1
    public float _minTorque; //0.1
    public float _maxTorque; //0.5
    

    // private AsteroidSpawner _asteroidSpawner;

    // private void Awake()
    // {
    //     ChangeValue();
    // }
    //
    // public void OnEnable()
    // {
    //     
    // }
    // public void ChangeValue() => _asteroidSpawner._maxSpawnTime = num;

    







}
