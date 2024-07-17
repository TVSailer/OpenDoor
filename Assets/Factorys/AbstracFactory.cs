using DefaultNamespace;
using Figures;
using UnityEngine;

namespace Factorys
{
    public abstract class AbstracFactory : MonoBehaviour
    {
        public abstract void CreateFigure(Figure[] figure, Transform point);
    }    
}

