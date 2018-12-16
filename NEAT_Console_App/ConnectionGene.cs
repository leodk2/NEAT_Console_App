using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEAT_Console_App
{
    class ConnectionGene
    {
        Node fromNode;
        Node toNode;
        float weight;
        bool enable = true;
        int innovationNo; //each connection is given an innovation number to compare genomes
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //constructor
        ConnectionGene(Node from, Node to, float w, int inno)
        {
            fromNode = from;
            toNode = to;
            weight = w;
            innovationNo = inno;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //changes the weight
        void MutateWeight()
        {
            
            
            Random random = new Random();
            Random r = new Random();
            float rand2 = random.Next(1);
            if (rand2 < 0.1)
            {//10% of the time completely change the weight
                weight = random.Next(-1, 1);
            }
            else
            {//otherwise slightly change it
                weight += Superbest_random.RandomExtensions.NextGaussian(r) / 50;
                //keep weight between bounds
                if (weight > 1)
                {
                    weight = 1;
                }
                if (weight < -1)
                {
                    weight = -1;

                }
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //returns a copy of this connectionGene
        ConnectionGene Clone(Node from, Node to)
        {
            ConnectionGene clone = new ConnectionGene(from, to, weight, innovationNo);
            clone.enable = true;

            return clone,
        }
    }
}
