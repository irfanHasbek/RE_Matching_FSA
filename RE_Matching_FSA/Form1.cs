using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RE_Matching_FSA_Project
{
    public partial class Form1 : Form
    {
        RegularExpression re = new RegularExpression();
        Hashtable FSA = new Hashtable();

        private State startState = new State("");
        private State acceptState = new State("");
        private State currentState = new State("");

        public Form1()
        {
            InitializeComponent();
        }

        private Hashtable CreateFSA(string input)
        {
            Hashtable p_FSA = new Hashtable();
            re.updateRegister(input);
            int stateCount = re.stateCount(input);

            string[] splittedInput = re.splitInput(input);

            for (int i = 0; i < stateCount; i++)
            {
                State temp = new State("S" + i);
                p_FSA.Add(temp.getLabel(),temp);
            }

            int inputCounter = 0;
            for (int i = 0; i < stateCount - 1; i++)
            {
                State sTranscation1 = (State)p_FSA["S" + i];
                State sTranscation2 = (State)p_FSA["S" + (i + 1)];

                if (re.isOperant(input.Substring(inputCounter,1)))
                {
                    sTranscation1.AddTransition(input.Substring(inputCounter, 1), sTranscation2);
                }

                if (re.registerQuery("+") && input.Substring(inputCounter,1).Equals("+"))
                {
                    sTranscation1.AddTransition(input.Substring(inputCounter - 1, 1), sTranscation1);
                    i--;
                }

                if (re.registerQuery(".") && input.Substring(inputCounter,1).Equals("."))
                {
                    for (int k = 0; k < re.operants.Length; k++)
                    {
                        if ((!sTranscation1.hasKey(re.operants[k])) && 
                            (!input.Substring(inputCounter + 1,1).Equals(re.operants[k])))
                        {
                            sTranscation1.AddTransition(re.operants[k], sTranscation1);
                        }
                    } 
                    i--;
                }

                if (re.registerQuery("[]") && input.Substring(inputCounter,1).Equals("["))
                {
                    inputCounter++;
                    while (!input.Substring(inputCounter,1).Equals("]"))
                    {
                        sTranscation1.AddTransition(input.Substring(inputCounter, 1), sTranscation2);
                        inputCounter++;
                    }
                }

                if (input.Substring(inputCounter,1).Equals("^"))
                {
                    i--;
                }
                inputCounter++;
            }

            if (re.registerQuery("^"))
            {
                State temp = (State)p_FSA["S" + (stateCount - 1)];

                for (int i = 0; i < re.operants.Length; i++)
                {
                    temp.AddTransition(re.operants[i], temp);
                }
            }

            if (re.registerQuery("$"))
            {
                State temp = (State)p_FSA["S0"];

                for (int l = 0; l < re.operants.Length; l++)
                {
                    if (!temp.hasKey(re.operants[l]))
                    {
                        temp.AddTransition(re.operants[l], temp);
                    }
                }
            }

            string s;
            startState = (State)p_FSA["S0"];
            acceptState = (State)p_FSA["S" + (stateCount - 1)];
            currentState = startState;

            return p_FSA;
        }

        private void StartFSA(Hashtable hTable, State start, State current, State accept, string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                string temp = input.Substring(i, 1);

                string stateLabel;
                if (current != null)
                {
                    stateLabel = current.GetTransitionState(temp);
                }
                else
                    stateLabel = "";
                State next;
                if (stateLabel == "")
                {
                    next = null;
                }
                else
                    next = getState(hTable, stateLabel);

                current = next;

                if (next != null && current != null && i == input.Length - 1 && current == accept)
                {
                    rtb_results.Text += input + "\n";
                    break;
                }
                if (next != null && current != null && i == input.Length - 1 && current != accept)
                {
                    break;
                }
            }
            current = start;
        }
        private State getState(Hashtable hshTable, string label)
        {
            State s = (State)hshTable[label];
            return s;
        }
        private void btn_check_Click(object sender, EventArgs e)
        {
            string s = rtb_inputs.Text;
            string[] arr = s.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);


            FSA = CreateFSA(txt_re.Text);
            for (int i = 0; i < arr.Length; i++)
            {
                StartFSA(FSA, startState, currentState, acceptState, arr[i]);
            }
        }
    }
}
