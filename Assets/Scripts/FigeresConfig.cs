using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FigeresConfig : ScriptableObject
{
   [SerializeField] private string nameFigure;
   [SerializeField] private Transform startPosition;
   [SerializeField] private Vector3 direction;
   [SerializeField] private GameObject figurePrefab;
  

   
   public string NameFigure => nameFigure;

   public Transform StartPosition => startPosition;

   public Vector3 Direction => direction;

   public GameObject FigurePrefab => figurePrefab;
   
}
