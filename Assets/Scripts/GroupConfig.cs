using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[CreateAssetMenu]
public class GroupConfig : ScriptableObject
{
   [SerializeField] private FigeresConfig[] figures;

   [SerializeField] private Material materialFigures;

   public Material MaterialFigures => materialFigures;
}
