# SearchUtilities

SearchUtilities is a shared .NET class library used by the SearchSystem microservices (`SearchAPI`, `indexer`, and `ConsoleSearch`). It provides the common `Tokenizer` and `TextNormalizer` used to split and NFKC-normalize text so that the indexer and the search side agree on what counts as a "word", the `Model` types (`BEDocument`, `SearchRequest`, `SearchResult`, `DocumentHit`) that define the wire contract between the search console/frontends and the search API, and the `Paths` class holding the shared Postgres connection string used by the API and indexer.
