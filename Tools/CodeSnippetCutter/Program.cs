﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippetCutter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Location of GitHub folder, where all repositories are located
            String baseGitHubFolder = @"C:\Users\Saqib Razzaq\Documents\GitHub\";

            // Aspose.3D for .NET
            String examples = baseGitHubFolder + @"Aspose_3D_NET\Examples",
                snippets = baseGitHubFolder + @"Gist_Saqib_Test";

            try
            {
                ExamplesToSnippetsConverter converter = new ExamplesToSnippetsConverter();
                converter.ProcessExamples(examples, snippets);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR processing the examples.\n\n" + ex.Message);
            }

            Console.WriteLine("\n\nProgram finished. Press any key to continue....");
            Console.ReadKey();
        }
    }
}