public class StepExtension
    {
        public int DistanceToSteps(double distance, int height)
        {
            return Convert.ToInt32(distance / (height * 0.45 / 100000));
        }
        public double StepsToDistance(int steps, int height)
        {
            return Math.Round(steps * height * 0.45 / 100000, 1);
        }
    }