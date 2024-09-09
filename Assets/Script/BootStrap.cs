using Levels;
using Factorys;
using Figures;
using UnityEngine;

namespace DefaultNamespace
{
    public class BootStrap : MonoBehaviour
    {
        public int _position = 0;
        
        [Header("Level")]
        [SerializeField] private Level _level;

        [Header("Player")]
        [SerializeField] private GameObject _player;
        [SerializeField] private PlayerUI _playerUI;
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
            
            _level._interactions[0].EventInteraction.AddListener(BlueFigures); 
            //_level._interactions[1].EventInteraction += RedFigures; 
            
            Instantiate(_playerUI);
            Instantiate(_player, _spawnPlayer.position, Quaternion.identity);
        }

        public void BlueFigures() => _position+=1;//_factoryBlueFigure.CreateFigure(_prefabFigures, _factoryBlueFigure.transform);
        
        private void RedFigures() => _factoryRedFigure.CreateFigure(_prefabFigures, _factoryRedFigure.transform);
    }
}