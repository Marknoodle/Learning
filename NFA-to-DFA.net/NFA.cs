namespace Automata
{
    class NFA
    {
       
        public NFA(string[] instates, string[] insigma, string instart, (string, string, string[])[] indelta, string[] infinals)//constructor
        {
            string[] Q = instates;
            string[] sigma = insigma;
            string Qnot = instart;
           (string, string, string[])[] transitions = indelta;
            string[] final = infinals;


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