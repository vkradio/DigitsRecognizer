using System.Collections.Generic;

namespace CSharp
{
    public class BasicClassifier : IClassifier
    {
        IEnumerable<Observation> data;
        readonly IDistance distance;

        public BasicClassifier(IDistance distance) => this.distance = distance;

        public void Train(IEnumerable<Observation> trainingSet) => data = trainingSet;

        public string Predict(int[] pixels)
        {
            Observation currentBest = null;
            var shortest = double.MaxValue;

            foreach (var obs in data)
            {
                var dist = distance.Between(obs.Pixels, pixels);
                if (dist < shortest)
                {
                    shortest = dist;
                    currentBest = obs;
                }
            }

            return currentBest.Label;
        }
    }
}
