using Levels;
using Factorys;
using Figures;
using UnityEngine;

namespace DefaultNamespace
{
    public class BootStrap : MonoBehaviour
    {
        [Header("Level")]
        [SerializeField] private Level _level;

        [Header("Player")]
        [SerializeField] private GameObject _player;
        private Transform _spawnPlayer;

        [Header("Factory")]
         [SerializeField] private Figure[] _prefabFigures;
        private FactoryBlueFigure _factoryBlueFigure;
        private FactoryRedFigure _factoryRedFigure;


        private void Start()
        {
            Instantiate(_level);

            _spawnPlayer = _level.SpawnPlayer;
            _factoryBlueFigure = _level.FactoryBlueFigure;
            _factoryRedFigure = _level.FactoryRedFigure;

            _factoryBlueFigure.CreateFigure(_prefabFigures, _factoryBlueFigure.transform);
            _factoryRedFigure.CreateFigure(_prefabFigures, _factoryRedFigure.transform);

            Instantiate(_player, _spawnPlayer.position, Quaternion.identity);
        }
    }
}