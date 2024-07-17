using Factorys;
using UnityEngine;

namespace Levels
{
    public class Level : MonoBehaviour
    {
        [Header("Factorys")]
        [SerializeField] private FactoryBlueFigure _factoryBlue;
        [SerializeField] private FactoryRedFigure _factoryRed;
        public FactoryBlueFigure FactoryBlueFigure => _factoryBlue;
        public FactoryRedFigure FactoryRedFigure => _factoryRed;
        
        [Header("Player")]
        [SerializeField] private Transform _spawnPlayer;
        public Transform SpawnPlayer => _spawnPlayer;
    }
}