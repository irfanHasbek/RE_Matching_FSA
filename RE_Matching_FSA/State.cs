using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RE_Matching_FSA_Project
{
    class State
    {
        private string label;
        private Hashtable Transitions;

        public State(string label)
        {
            this.label = label;
            Transitions = new Hashtable();
        }
        public void setLabel(string label)
        {
            this.label = label;
        }
        public string getLabel()
        {
            return this.label;
        }
        public void AddTransition(string input, State arr) 
        {
            Transitions.Add(input,arr.getLabel());
        }
        public String GetTransitionState(string input) 
        {
            try
            {
                string label = Transitions[input].ToString();
                return label;
            }
            catch (Exception)
            {
                return "";
                throw;
            }
            
        }
        public bool hasKey(string key)
        {
            if (Transitions.Contains(key))
            {
                return true;
            }
            else
                return false;
        }
    }
}

