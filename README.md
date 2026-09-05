# SearchUtilities

Shared code for the SearchSystem microservices (`SearchAPI`, `indexer`, `ConsoleSearch`):

- `Tokenizer` / `TextNormalizer` - identical word-splitting and NFKC normalization, so the
  indexer and search side agree on what a "word" is.
- `Model.BEDocument` - the indexed document shape.
- `Model.SearchRequest` / `Model.SearchResult` / `Model.DocumentHit` - the wire contract
  between ConsoleSearch (and future frontends) and SearchAPI.
- `Paths` - the Postgres connection string shared by SearchAPI and the indexer.
