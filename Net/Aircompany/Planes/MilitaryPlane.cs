using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            Type = type;
        }

        public MilitaryType Type { get; private set; }

        public override bool Equals(object obj)
        {
            MilitaryPlane plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   Type == plane.Type;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + Type.GetHashCode();
        }


        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + Type +
                    '}');
        }        
    }
}
