using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            PassengersCapacity = passengersCapacity;
        }
        public int PassengersCapacity { get; private set; }

        public override bool Equals(object obj)
        {
            PassengerPlane plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   PassengersCapacity == plane.PassengersCapacity;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + PassengersCapacity.GetHashCode();
        }
       
        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + PassengersCapacity +
                    '}');
        }       
        
    }
}
