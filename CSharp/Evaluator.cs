using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class Evaluator
    {
        static double Score(Observation obs, IClassifier classifier) => classifier.Predict(obs.Pixels) == obs.Label ? 1.0 : 0.0;

        public static double Correct(IEnumerable<Observation> validationSet, IClassifier classifier) => validationSet
            .Select(obs => Score(obs, classifier))
            .Average();
    }
}
