using System;
using System.Collections.Generic;
using System.Text;

namespace Da29PracticeProblem_MoodAnalyzer
{
    public class MoodAnalyzer
    {
        public string msg;
        //public MoodAnalyzer(string msg)
        //{
        //    this.msg = msg;
        //}

        public string AnalyseMood(string msg)
        {
            
                if (msg.ToLower().Contains("sad"))
                    return "HAPPY";

                else
                    return "SAD";
            }
            

       
        }
    }


