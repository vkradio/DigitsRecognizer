using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = new ManhattanDistance();
            var classifier = new BasicClassifier(distance);

            var trainingPath = @"C:\_svn_wc\xsb\_edu\FSharp\ML for .NET\DigitsRecognizer\Data\trainingsample.csv";
            var training = DataReader.ReadObservations(trainingPath);
            classifier.Train(training);

            var validationPath = @"C:\_svn_wc\xsb\_edu\FSharp\ML for .NET\DigitsRecognizer\Data\validationsample.csv";
            var validation = DataReader.ReadObservations(validationPath);

            var correct = Evaluator.Correct(validation, classifier);
            Console.WriteLine($"Correctly classified: {correct:P2}");

            Console.ReadLine();
        }
    }
}
