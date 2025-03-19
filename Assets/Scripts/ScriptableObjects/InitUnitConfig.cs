using System;
using System.Collections;
using System.Collections.Generic;
using RVO;
using UnityEngine;

[CreateAssetMenu(fileName = "InitUnitConfig", menuName = "ScriptableObjects/InitUnitConfig")]
public class InitUnitConfig : ScriptableObject
{
    public List<UnityAgent> Agents ;
}

[Serializable]
public class UnityAgent
{
    public Vector3 position;
    public Quaternion rotation;
    public GameObject prefab;
}
