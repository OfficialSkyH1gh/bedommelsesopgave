using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedømmelsesopgave.Codes
{
    internal class EducationalProgram
    {
        List<Elever> _programStudents;
        string _programName;
        string _teacher;

        internal EducationalProgram(List<Elever> ProgramStudents, string programName, string teacher)
        {
            this._programStudents = ProgramStudents;
            this._programName = programName;
            this._teacher = teacher;
        }
        public List<Elever> ProgramStudents()
        {
            return this._programStudents;
        }
        public string ProgramName()
        {
            return this._programName;
        }
        public string Teacher() 
        {
            return this._teacher;
        }
    }
}
