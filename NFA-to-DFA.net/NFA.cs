namespace Automata
{
    public class NFA
    {
        // alphabet :: list of strings that represent our alphabet
        private string[] alphabet {get; set;}
        // states :: list of state names
        private string[] states {get; set;}
        // transitions :: current state, input, resulting state
        private (string, string, string[])[] nfaTransitions {get; set;}//state , alphabet, new states (epsilon closer)
        // start state :: string
        private string startState {get; set;}
        // final states :: list of strings
        private string[] finalStates {get; set;}

        public NFA(string[] _alphabet, string[] _states, (string, string, string[])[] _transitions, string _startState, string[] _finalStates)
        {
            alphabet = _alphabet;
            states = _states;
            nfaTransitions = _transitions;
            startState = _startState;
            finalStates = _finalStates;
        }

    }
}


/*

Main()

 tupleType nfaSetTuple //tuple made ourselves

 NFA bobbyboy = new NFA(nfaSetTuple)//NFA constructor
 
 NFA richy = new NFA(Nfa2NFA( bobbyboy  )   ) //NFA constructor

 NFA :: (string[], string[], (string, string, string)[], string, string[]) // alphabet, states, transitions, startState, finalStates 
 NFA :: (string[], string[], (string, string, string)[], string, string[]) // same as order NFA
 Nfa2NFA :: NFA -> NFA

step 1: create NFA object using nfaSetTuple

step 2: feed nfa obj to Nfa2NFA() 

step 3: construct NFA object using return of step 2


*/


/* //Syd Work
public NFA(string[] instates, string[] insigma, string instart, (string, string, string[])[] indelta, string[] infinals)//constructor
        {
            string[] Q = instates;
            string[] sigma = insigma;
            string Qnot = instart;
           (string, string, string[])[] transitions = indelta;
            string[] final = infinals;


        }
*/