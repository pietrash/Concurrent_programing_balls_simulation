namespace Data
{
    public interface IData
    {
        void AddOrb(double radius, double posX, double posY, double velX, double velY, int id, double massMultiplier = 1);

        List<Orb> GetOrbs();

        void ClearOrbs();

        double SceneXDimension { get; set; }

        double SceneYDimension { get; set; }

        bool IsEnabled { get; set; }
    }
}
