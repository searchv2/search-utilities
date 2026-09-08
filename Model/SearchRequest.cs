namespace Shared.Model;

// Wire contract for ConsoleSearch (and future frontends) to call SearchAPI's /api/search.
public record SearchRequest(string[] Query, bool CaseSensitive);
