using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System.Collections.Generic;
using System.Linq;

namespace simple_qubit_beahviours
{
    class Driver
    {
        static void Main(string[] args)
        {
            foreach (var i in Enumerable.Range(0, 20))
            {
                var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);
                var results = ShowEntanglment.Run(sim).Result;
                System.Console.WriteLine($"Measured CNOT and H |00〉 and observed {results}.");      
            }
        }
    }
}