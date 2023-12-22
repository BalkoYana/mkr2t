using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr2t
{
    public class DistanceLearningSystem
    {
        private List<Person> _participants = new List<Person>();

        public void AddParticipant(Person person)
        {
            _participants.Add(person);
        }

        public void DisplayParticipantsInfo()
        {
            Visitor visitor = new Info();
            foreach (var participant in _participants)
            {
                participant.Accept(visitor);
            }
        }
    }
}
