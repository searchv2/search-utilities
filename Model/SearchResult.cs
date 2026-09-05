using System;
using System.Collections.Generic;

namespace Shared.Model
{
    /*
     * A data class representing the result of a search.
     * Hits is the total number of documents containing at least one word from the query.
     * DocumentHits is the documents and the number of words from the query contained in the document - see
     * the class DocumentHit
     * Ignored contains words from the query not present in the document base.
     * TimeUsed is the timespan used to perform the search.
     */
    public class SearchResult
    {
        public required String[] Query { get; init; }

        public required int Hits { get; init; }

        public required List<DocumentHit> DocumentHits { get; init; }

        public required List<string> Ignored { get; init; }

        public required TimeSpan TimeUsed { get; init; }
    }
}
