
using System.Collections;
using System.Collections.Generic;
namespace DieseaseSim
{
    public abstract class Diesease
    {
        public string Name;
        // The name of the diesease

        public double Infectivity;
        // The ability of the agent to enter a host and multiply to an infectious dose, thereby producing the infection or disease.

        public double Pathogenicity;
        // The ability of the agent to cause disease in an infected host.

        public double Virulence;
        // refers to the severity of the infection. A highly virulent strain of a disease agent will most always produce severe cases or death.

        public double Toxigenicity;
        /* refers to the ability of the agent to produce a toxin. The resulting illness or disease is from the toxin 
        produced by the organism/agent and not the microorganism itself. */

        public double Resistance;
        // refers to the ability of the agent to survive under adverse environmental conditions. It is also a measure of the agent's fragility.

        public double Antigenicity;
        /* refers to the ability of the agent to induce antibody production in the host. Agents that have a high antigenicity 
        have a very low reinfection rate, whereas, agents with a low antigenicity rate have a higher reinfection rate.*/

        public enum Chronicity { ShortTerm, LongTerm, Debilitating, Lethal };
        // How long the dieseases impacts will last, will it last a week, will it kill them, will it debilitate them for life. And so on.

        //public List<Symptom> Symptoms;

        public abstract bool Infect(/*person victim*/);
        public abstract void Mutate();

    }
}