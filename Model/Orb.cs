using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Model
{
    public class Orb : INotifyPropertyChanged
    {
        private double radius;
        private double posX;
        private double posY;

        public Orb(Logic.Orb o)
        {
            Radius = o.Radius;
            PositionX = o.PositionX;
            PositionY = o.PositionY;
            o.PropertyChanged += Update;
        }

        private void Update(object source, PropertyChangedEventArgs e)
        {
            Logic.Orb changedOrb = (Logic.Orb)source;
            if (e.PropertyName == "PositionX")
            {
                PositionX = changedOrb.PositionX;
            }
            if (e.PropertyName == "PositionY")
            {
                PositionY = changedOrb.PositionY;
            }
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                OnPropertyChanged(nameof(Radius));
            }
        }

        public double PositionX
        {
            get { return posX; }
            set
            {
                posX = value;
                OnPropertyChanged(nameof(PositionX));
            }
        }

        public double PositionY
        {
            get { return posY; }
            set
            {
                posY = value;
                OnPropertyChanged(nameof(PositionY));
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
