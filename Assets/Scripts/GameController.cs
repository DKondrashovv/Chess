using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private FigeresConfig[] figeresConfigs; 
    [SerializeField] private GroupConfig[] groupConfigs;
    [SerializeField] private Material material;
    void Start()
    {
        GameObject obj;
        foreach (var figure in figeresConfigs)
        {
            if (figure.NameFigure == "Pawn")
            {
                for (int i = 0; i < 8; i++)
                {
                   obj= Instantiate(figeresConfigs[i].FigurePrefab,new Vector3(i,0,1),Quaternion.identity);
                    obj= Instantiate(figeresConfigs[i].FigurePrefab,new Vector3(i,0,6),Quaternion.identity);
                    //obj.GetComponent<MeshRenderer>() = material;
                }
            }

            if (figure.NameFigure == "Knight")
            {
                for (int i = 0; i < 2; i++)
                { 
                    Instantiate(figeresConfigs[i].FigurePrefab,new Vector3(1,0,0),Quaternion.identity);
                    
                }
            }
            if (figure.NameFigure == "Bishop")
            {
                for (int i = 0; i < 2; i++)
                { 
                    Instantiate(figeresConfigs[i].FigurePrefab,new Vector3(1,0,0),Quaternion.identity);
                                        
                }
            }
            if (figure.NameFigure == "King")
            {
                for (int i = 0; i < 1; i++)
                { 
                    Instantiate(figeresConfigs[i].FigurePrefab,new Vector3(1,0,0),Quaternion.identity);
                                        
                }
            }
            if (figure.NameFigure == "Rook")
            {
                for (int i = 0; i < 2; i++)
                { 
                    Instantiate(figeresConfigs[i].FigurePrefab,new Vector3(1,0,0),Quaternion.identity);
                                        
                }
            }
        }
    }

    
    void Update()
    {
        
    }
}
