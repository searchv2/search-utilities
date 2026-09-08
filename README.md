# SearchUtilities

SearchUtilities is a shared .NET class library used by the SearchSystem microservices (`SearchAPI`, `indexer`, and `ConsoleSearch`). It provides the common `Tokenizer` and `TextNormalizer` used to split and NFKC-normalize text so that the indexer and the search side agree on what counts as a "word", and the `Model` types (`BEDocument`, `SearchRequest`, `SearchResult`, `DocumentHit`) that define the wire contract between the search console/frontends and the search API.

## Docker

`Dockerfile` builds the NuGet package only (this is a library, not a service):

```bash
docker build -t search-utilities .
```

The `SearchAPI`, `indexer`, and `ConsoleSearch` images build this package
themselves, so you normally don't need to run this directly.
