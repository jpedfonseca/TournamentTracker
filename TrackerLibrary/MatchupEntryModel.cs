using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Representa uma equipa num jogo.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Representa o resultado para uma equipa especifica.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Representa o jogo de onde a equipa veio como vencedora.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
