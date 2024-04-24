using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Data
{
    public class Orb : INotifyPropertyChanged
    {
        private readonly double radius;

        private double posX;
        private double posY;

        private double velX;
        private double velY;

        private double massMultiplier;

        private readonly int id;

        public Orb(double radius, double posX, double posY, double velX, double velY, int id, double massMultiplier)
        {
            this.radius = radius;
            this.posX = posX;
            this.posY = posY;
            this.velX = velX;
            this.velY = velY;
            this.id = id;
            this.massMultiplier = massMultiplier;
        }

        public int Id
        {
            get { return id; }
        }

        public double MassMultiplier
        {
            get { return massMultiplier; }
            set { massMultiplier = value; }
        }

        public double Radius { get { return radius; } }

        public double PositionX
        {
            get { return posX; }
            set
            {
                lock (this)
                {
                    posX = value;
                    OnPropertyChanged(nameof(PositionX));
                }
            }
        }

        public double PositionY
        {
            get { return posY; }
            set
            {
                lock (this)
                {
                    posY = value;
                    OnPropertyChanged(nameof(PositionY));
                }
            }
        }

        public double VelocityX
        {
            get { return velX; }
            set
            {
                lock (this)
                {
                    velX = value;
                }
            }
        }

        public double VelocityY
        {
            get { return velY; }
            set
            {
                lock (this)
                {
                    velY = value;
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
