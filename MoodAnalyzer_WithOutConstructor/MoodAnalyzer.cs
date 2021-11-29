using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer_WithOutConstructor
{
   public class MoodAnalyzer
    {
     // public MoodAnalyzer(string msg)
       //{
        //}

        public string AnalyseMood(string msg)
            {
                if (msg.ToLower().Contains("sad"))
                    return "SAD";

                else
                    return "HAPPY";
            }

        public string AnalyseMood()
        {
            throw new NotImplementedException();
        }
    }
    }

