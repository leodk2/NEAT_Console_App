using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEAT_Console_App
{
    class ConnectionHistory
    {
        int fromNode;
        int toNode;
        int innovationNumber;

        List<int> innovationNumbers = new List<int>(); // the innovation Numbers from the connection of the genome which first had this mutation
                                                       //this represents the genome and allows us to test if another genome is the same
                                                       // this is before this connection was added

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //constructor
        ConnectionHistory(int from, int to, int inno, List<int> innovationNos)
        {
            fromNode = from;
            toNode = to;
            innovationNumber = inno;
            innovationNumbers = innovationNos;

        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //returns whether the genome matches the original genome and the connection is between the same nodes
        Boolean matches()
    }
}
