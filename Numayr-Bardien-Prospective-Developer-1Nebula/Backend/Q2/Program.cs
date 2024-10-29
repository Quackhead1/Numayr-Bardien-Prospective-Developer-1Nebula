public enum RobotType { RoboticDog, RoboticCat, RoboticDrone, RoboticCar }
public enum CarType { Toyota, Ford, Opel, Honda }

public interface IRobotService
    {
        Robot BuildRobotDog(List<Parts> parts);
        Robot BuildRobotCat(List<Parts> parts);
        Robot BuildRobotDrone(List<Parts> parts);
        Robot BuildRobotCar(List<Parts> parts);
    }

public interface ICarService
    {
        Car BuildCar(List<Parts> parts);
    }

public interface IPartsService
    {
        List<Parts> GetParts(Enum type);
    }

public class RobotFactory
    {
        private readonly IRobotService _robotService;
        private readonly IPartsService _partsService;

        public RobotFactory(IRobotService robotService, IPartsService partsService)
        {
            _robotService = robotService;
            _partsService = partsService;
        }

        public Robot BuildRobot(RobotType robotType)
        {
            var parts = _partsService.GetParts(robotType);
            return robotType switch
            {
                RobotType.RoboticDog => _robotService.BuildRobotDog(parts),
                RobotType.RoboticCat => _robotService.BuildRobotCat(parts),
                RobotType.RoboticDrone => _robotService.BuildRobotDrone(parts),
                RobotType.RoboticCar => _robotService.BuildRobotCar(parts),
                _ => throw new ArgumentException("Invalid Robot Type")
            };
        }
    }

public class CarFactory
    {
        private readonly ICarService _carService;
        private readonly IPartsService _partsService;

        public CarFactory(ICarService carService, IPartsService partsService)
        {
            _carService = carService;
            _partsService = partsService;
        }

        public Car BuildCar(CarType carType)
        {
            var parts = _partsService.GetParts(carType);
            return _carService.BuildCar(parts);
        }
    }