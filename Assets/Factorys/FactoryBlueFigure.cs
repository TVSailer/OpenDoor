using Figures;
using UnityEngine;

namespace Factorys
{
    public class FactoryBlueFigure : AbstracFactory
    {
        [SerializeField] private Material _materialColorBlue;
        public override void CreateFigure(Figure[] figure, Transform point)
        {
            var position = Vector3.zero;
            foreach (Figure fig in figure)
            {
                position.z -= 1;
                fig.GetComponent<MeshRenderer>().material = _materialColorBlue;
                Instantiate(fig, point.transform.position + position, Quaternion.identity);
            }
        }
    }
}