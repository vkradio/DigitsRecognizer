﻿namespace CSharp
{
    public class Observation
    {
        public Observation(string label, int[] pixels)
        {
            Label = label;
            Pixels = pixels;
        }

        public string Label { get; }

        public int[] Pixels { get; }
    }
}
