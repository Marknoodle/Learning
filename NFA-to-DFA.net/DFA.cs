namespace Automata
{
    public class DFA
    {
        // alphabet :: list of stringacters that represent our alphabet
        private string[] alphabet {get; set;}
        // states :: list of state names
        private string[] states;
        // transitions :: current state, input, resulting state
        private (string, string, string)[] transitions;
        // start state :: string
        private string startState;
        // final states :: list of strings
        private string[] finalStates;

        public DFA(string[] _alphabet, string[] _states, (string, string, string)[] _transitions, string _startState, string[] _finalStates)
        {
            alphabet = _alphabet;
            states = _states;
            transitions = _transitions;
            startState = _startState;
            finalStates = _finalStates;
        }

        public (string[], string[], (string, string, string)[], string, string[]) retDFA()
        {
            return (alphabet,states,transitions,startState,finalStates);
        }
    }
}
/*

Main()

 tupleType nfaSetTuple //tuple made ourselves

 NFA bobbyboy = new NFA(nfaSetTuple)//NFA constructor
 
 DFA richy = new DFA(Nfa2Dfa( bobbyboy  )   ) //DFA constructor

 NFA :: (string[], string[], (string, string, string)[], string, string[]) // alphabet, states, transitions, startState, finalStates 
 DFA :: (string[], string[], (string, string, string)[], string, string[]) // same as order NFA
 Nfa2Dfa :: NFA -> DFA

step 1: create NFA object using nfaSetTuple

step 2: feed nfa obj to Nfa2Dfa() 

step 3: construct DFA object using return of step 2


*/