using System.Collections.Generic;

namespace Shared.Model
{
    public class DocumentHit
    {
        public required BEDocument Document { get; init; }

        public required int NoOfHits { get; init; }

        public required List<string> Missing { get; init; }
    }
}
