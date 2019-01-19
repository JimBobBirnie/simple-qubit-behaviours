namespace simple_qubit_beahviours
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation ShowEntanglment () : (Result, Result)
    {
        body
        {
            mutable result = (Zero, Zero);
            using (qubits = Qubit[2])
            {
                let control = qubits[0];
                let target = qubits[1];

                H(control);
                CNOT(control, target);

                //X(control);
                set result = (M(qubits[0]), M(qubits[1]));		
                ResetAll(qubits);		
            }
            return result;
        }
    }
}    

